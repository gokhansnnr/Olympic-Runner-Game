using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFootsteps : MonoBehaviour
{
    //Ad�mlarda ses ��karmas� i�in:
    public AudioClip[] footstepClips; //1- Farkl� ad�m sesleri ekleyece�imiz i�in liste olu�turduk.
    public AudioSource audioSource; //2- En son yapt���m�z �ey sourcede �alacak.

    public CharacterController controller; //3- Bunu da rigidbodysine uygulayaca��z.
    public float footstepTheshold; //4- Karakterin h�z�yla da alakal� i�lemler yapal�m. �r. Admlar �undan fazlaysa ba�las�n gibi.
    public float footstepRate; //5- Kendi h�z�nda tutsun diye.
    private float lastFootstepTime; //6-Ad�mlar� haf�zada tutmak i�in.

    void FixedUpdate()
    { //Hareket, ses gibi i�lemleri burada yapmam�z daha iyi olur.

        if (controller.velocity.magnitude > footstepTheshold)
        {//7-Karakter hareketinin h�z bilgisi e�ik de�erinden fazla ise

            if (Time.time - lastFootstepTime > footstepRate)
            { //8- Zaman aral���nda son ad�m zaman�n� ��kard���m�zda ��kan sonu� bizim h�zdan b�y�kse

                lastFootstepTime = Time.time; //9- Bu �ekilde aradaki 0,03l�k fark kendi zaman�na e�itlenecek.

                audioSource.PlayOneShot(footstepClips[Random.Range(0, footstepClips.Length)]); //10- Ad�mlardan rastgele birini bir kere �al dedik.

            }
        }
    }
}
