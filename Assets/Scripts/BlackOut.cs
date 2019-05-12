using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;

    public static class BlackOut
{
    public static void FadeScreen(Color color, float fromAlpha, float toAlpha, float fadeTimeSeconds, Action endAction = null)
    {
        Image image = createFadeImage();
        image.StartCoroutine(fadeCoroutine(image, color, fromAlpha, toAlpha, fadeTimeSeconds, endAction));
    }


    private static Image createFadeImage()
    {
        GameObject canvasGo = new GameObject("CanvasEffect");
        Canvas canvas = canvasGo.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvas.sortingOrder = 100;

        GameObject imageGo = new GameObject("FadeImage");
        imageGo.transform.SetParent(canvasGo.transform);

        Image image = imageGo.AddComponent<Image>();
        image.rectTransform.anchoredPosition = Vector2.zero;
        image.rectTransform.sizeDelta = new Vector2(Screen.width, Screen.height);

        return image;
    }

    private static IEnumerator fadeCoroutine(Image image, Color color, float fromAlpha, float toAlpha, float fadeTimeSeconds, Action action)
    {
        color.a = fromAlpha;
        image.color = color;

        float time = 2f / fadeTimeSeconds;
        float progress = 0;

        while (progress < 1)
        {
            progress += time * Time.deltaTime;
            color.a = Mathf.Lerp(fromAlpha, toAlpha, progress);
            image.color = color;
            yield return null;
        }

        if (action != null) action.Invoke();

        GameObject.Destroy(image.transform.root.gameObject,1);
    }
}

