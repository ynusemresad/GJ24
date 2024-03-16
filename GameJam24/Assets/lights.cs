using System.Collections;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public Light myLight; // Yanýp sönecek ýþýðý belirtin
    public float countdownTime = 10.0f; // Geri sayým süresi

    void Update()
    {
        countdownTime -= Time.deltaTime; // Geri sayýmý azalt

        if (countdownTime <= 0)
        {
            StartCoroutine(FlickerLight()); // Geri sayým bittiðinde ýþýðý yanýp söndür
        }
    }

    IEnumerator FlickerLight()
    {
        while (true) // Sürekli yanýp sönsün
        {
            myLight.enabled = !myLight.enabled; // Iþýðý aç/kapat
            yield return new WaitForSeconds(0.5f); // Her yanýp sönme arasýnda bekleme süresi
        }
    }
}