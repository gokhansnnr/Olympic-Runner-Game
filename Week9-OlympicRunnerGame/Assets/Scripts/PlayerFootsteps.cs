using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFootsteps : MonoBehaviour
{
    //Adýmlarda ses çýkarmasý için:
    public AudioClip[] footstepClips; //1- Farklý adým sesleri ekleyeceðimiz için liste oluþturduk.
    public AudioSource audioSource; //2- En son yaptýðýmýz þey sourcede çalacak.

    public CharacterController controller; //3- Bunu da rigidbodysine uygulayacaðýz.
    public float footstepTheshold; //4- Karakterin hýzýyla da alakalý iþlemler yapalým. Ör. Admlar þundan fazlaysa baþlasýn gibi.
    public float footstepRate; //5- Kendi hýzýnda tutsun diye.
    private float lastFootstepTime; //6-Adýmlarý hafýzada tutmak için.

    void FixedUpdate()
    { //Hareket, ses gibi iþlemleri burada yapmamýz daha iyi olur.

        if (controller.velocity.magnitude > footstepTheshold)
        {//7-Karakter hareketinin hýz bilgisi eþik deðerinden fazla ise

            if (Time.time - lastFootstepTime > footstepRate)
            { //8- Zaman aralýðýnda son adým zamanýný çýkardýðýmýzda çýkan sonuç bizim hýzdan büyükse

                lastFootstepTime = Time.time; //9- Bu þekilde aradaki 0,03lük fark kendi zamanýna eþitlenecek.

                audioSource.PlayOneShot(footstepClips[Random.Range(0, footstepClips.Length)]); //10- Adýmlardan rastgele birini bir kere çal dedik.

            }
        }
    }
}
