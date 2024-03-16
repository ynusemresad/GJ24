using System.Collections;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public Light myLight; // Yan�p s�necek ����� belirtin
    public float countdownTime = 10.0f; // Geri say�m s�resi

    void Update()
    {
        countdownTime -= Time.deltaTime; // Geri say�m� azalt

        if (countdownTime <= 0)
        {
            StartCoroutine(FlickerLight()); // Geri say�m bitti�inde ����� yan�p s�nd�r
        }
    }

    IEnumerator FlickerLight()
    {
        while (true) // S�rekli yan�p s�ns�n
        {
            myLight.enabled = !myLight.enabled; // I���� a�/kapat
            yield return new WaitForSeconds(0.5f); // Her yan�p s�nme aras�nda bekleme s�resi
 }
    }
}