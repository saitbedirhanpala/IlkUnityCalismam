using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;     // float bir hız değişkeni oluşturdum.
    private float turnSpeed=45f;   // aracımın rotasyonununda değişimi için bir float dönüş hızı değişkeni oluşturdum.
    private float horizontalInput; // yatay hareketleri tanımlayacağım bir float değişken oluşturdum.
    private float forwardInput;    // dikey hareketleri tanımlayacağım bir float değişken oluşturdum.
    void Start()
    {
        
    }

    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); //input fonksiyonu ile  yatay hareket için tuş atadım
        forwardInput = Input.GetAxis("Vertical");      //input fonksiyonu ile  dikey hareket için tuş atadım
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput); // aracın hareket etmesi için tanımladığım kod parçacığı
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);// aracın hareket ederken dönmesi için atadığım kod parçacığı
        
    }
}
