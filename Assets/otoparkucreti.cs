using UnityEngine;

public class otoparkucreti : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int parkSuresi = 1;

    void Start()
    {
        Debug.Log("Otaparkta Kalınan Süre:" + parkSuresi + "Saat");

        switch (parkSuresi)
        {
            case 1:
                Debug.Log("Ödenecek Tutar 120 TL");
                break;
            case 2:
                Debug.Log("Ödenecek Tutar 200TL");
                break;
            case 3:
                Debug.Log("Ödenecek Tutar 300TL");
                break;
            case 4:
                Debug.Log("Ödenecek Tutar 400TL");
                break;
            default:
                Debug.Log("Ödenecek Tutar 550Tl");
                break;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 