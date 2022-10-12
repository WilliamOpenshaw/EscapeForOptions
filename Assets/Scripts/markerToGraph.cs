using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class markerToGraph : MonoBehaviour
{
    public listener coordinates;
    void Start()
    {
        //gameObject.transform.localPosition.x = Random.Range(-669.0f, 768.0f);
        //gameObject.transform.localPosition.y = Random.Range(-508.0f, 458.0f);
        //gameObject.transform.localPosition = new Vector3(Random.Range(-669.0f, 768.0f), Random.Range(-508.0f, 458.0f), 0);
        gameObject.SetActive(false);
        gameObject.SetActive(true);
    }
    //void Update()
    //{
    //}
/*
    private void OnEnable()
    {
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.a1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.a2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.a3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.a4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.a5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.a6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.a7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.a8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.a9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.a10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.a11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.a12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.a13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.a14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.a15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.a16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.a17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.a18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.a19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.a20Bombable = true;
        }
        //BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.b1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.b2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.b3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.b4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.b5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.b6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.b7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.b8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.b9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.b10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.b11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.b12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.b13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.b14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -616
             && gameObject.transform.localPosition.x <= -562
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.b15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.b16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.b17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.b18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.b19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.b20Bombable = true;
        }
        //CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.c1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.c2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.c3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.c4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.c5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.c6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.c7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.c8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.c9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.c10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.c11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.c12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.c13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.c14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.c15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.c16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.c17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.c18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.c19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.c20Bombable = true;
        }
        //DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.d1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.d2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.d3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.d4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.d5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.d6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.d7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -506
             && gameObject.transform.localPosition.x <= -451
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.d8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.d9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.d10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.d11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -506
             && gameObject.transform.localPosition.x <= -451
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.d12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.d13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.d14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.d15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.d16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.d17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.d18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.d19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.d20Bombable = true;
        }
        //EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.e1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.e2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.e3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.e4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.e5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.e6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.e7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.e8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.e9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.e10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.e11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.e12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.e13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.e14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.e15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.e16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.e17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.e18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.e19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.e20Bombable = true;
        }
        //FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.f1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.f2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.f3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.f4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.f5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.f6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.f7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.f8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.f9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.f10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.f11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.f12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.f13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.f14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.f15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.f16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.f17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.f18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.f19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.f20Bombable = true;
        }
        //GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.g1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.g2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.g3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.g4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.g5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.g6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.g7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.g8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.g9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.g10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.g11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.g12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.g13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.g14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.g15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.g16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.g17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.g18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.g19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.g20Bombable = true;
        }
        //HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.h1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.h2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.h3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.h4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.h5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.h6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.h7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.h8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.h9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.h10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.h11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.h12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.h13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.h14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.h15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.h16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.h17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.h18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.h19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.h20Bombable = true;
        }
        //IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.i1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.i2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.i3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.i4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.i5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.i6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.i7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.i8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.i9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.i10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.i11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.i12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.i13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.i14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.i15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.i16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.i17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.i18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.i19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.i20Bombable = true;
        }
        //JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.j1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.j2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.j3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.j4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.j5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.j6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.j7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.j8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.j9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.j10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.j11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.j12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.j13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.j14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.j15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.j16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.j17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.j18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.j19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.j20Bombable = true;
        }
        //KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.k1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.k2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.k3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.k4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.k5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.k6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.k7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.k8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.k9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.k10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.k11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.k12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.k13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.k14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.k15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.k16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.k17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.k18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.k19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.k20Bombable = true;
        }
        //LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.l1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.l2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.l3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.l4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.l5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.l6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.l7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.l8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.l9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.l10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.l11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.l12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.l13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.l14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.l15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.l16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.l17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.l18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.l19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.l20Bombable = true;
        }
        //MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.m1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.m2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.m3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.m4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.m5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.m6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.m7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.m8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.m9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.m10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.m11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.m12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.m13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.m14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.m15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.m16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.m17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.m18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.m19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.m20Bombable = true;
        }
        //NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.n1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.n2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.n3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.n4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.n5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.n6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.n7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.n8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.n9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.n10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.n11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.n12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.n13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.n14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.n15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.n16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.n17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.n18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.n19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.n20Bombable = true;
        }
        //OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.o1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.o2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.o3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.o4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.o5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.o6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.o7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.o8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.o9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.o10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.o11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.o12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.o13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.o14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.o15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.o16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.o17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.o18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.o19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.o20Bombable = true;
        }
        //PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP

        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.p1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.p2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.p3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.p4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.p5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.p6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.p7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.p8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.p9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.p10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.p11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.p12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.p13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.p14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.p15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.p16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.p17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.p18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.p19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.p20Bombable = true;
        }
        //QQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQ
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.q1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.q2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.q3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.q4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.q5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.q6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.q7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.q8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.q9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.q10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.q11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.q12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.q13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.q14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.q15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.q16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.q17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.q18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.q19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.q20Bombable = true;
        }
        //RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.r1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.r2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.r3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.r4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.r5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.r6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.r7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.r8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.r9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.r10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.r11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.r12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.r13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.r14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.r15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.r16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.r17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.r18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.r19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.r20Bombable = true;
        }
        //SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.s1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.s2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.s3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.s4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.s5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.s6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.s7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.s8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.s9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.s10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.s11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.s12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.s13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.s14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.s15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.s16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.s17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.s18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.s19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.s20Bombable = true;
        }
        //TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.t1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.t2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.t3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.t4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.t5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.t6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.t7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.t8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.t9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.t10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.t11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.t12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.t13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.t14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.t15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.t16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.t17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.t18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.t19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.t20Bombable = true;
        }
        //UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.u1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.u2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.u3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.u4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.u5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.u6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.u7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.u8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.u9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.u10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.u11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.u12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.u13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.u14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.u15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.u16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.u17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.u18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.u19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.u20Bombable = true;
        }
        //VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV

        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.v1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.v2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.v3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.v4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.v5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.v6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.v7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.v8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.v9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.v10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.v11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.v12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.v13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.v14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.v15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.v16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.v17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.v18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.v19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.v20Bombable = true;
        }
        //WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.w1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.w2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.w3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.w4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.w5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.w6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.w7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.w8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.w9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.w10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.w11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.w12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.w13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.w14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.w15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.w16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.w17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.w18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.w19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.w20Bombable = true;
        }
        //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.x1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.x2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.x3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.x4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.x5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.x6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.x7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.x8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.x9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.x10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.x11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.x12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.x13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.x14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.x15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.x16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.x17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.x18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.x19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.x20Bombable = true;
        }
        //YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY
        if (gameObject.transform.localPosition.x >= 661
                     && gameObject.transform.localPosition.x <= 716
                     && gameObject.transform.localPosition.y >= 413
                     && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.y1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.y2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.y3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.y4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.y5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.y6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.y7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.y8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.y9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.y10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.y11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.y12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.y13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.y14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.y15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.y16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.y17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.y18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.y19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.y20Bombable = true;
        }
        //ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ
        if (gameObject.transform.localPosition.x >= 716
           && gameObject.transform.localPosition.x <= 772
           && gameObject.transform.localPosition.y >= 413
           && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.z1Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.z2Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.z3Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.z4Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.z5Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.z6Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.z7Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.z8Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.z9Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.z10Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.z11Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.z12Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.z13Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.z14Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.z15Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.z16Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.z17Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.z18Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.z19Bombable = true;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.z20Bombable = true;
        }
    }
    private void OnDisable()
    {
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.a1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.a2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.a3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.a4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.a5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.a6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.a7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.a8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.a9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.a10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.a11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.a12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.a13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.a14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.a15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.a16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.a17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.a18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.a19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -673
            && gameObject.transform.localPosition.x <= -616
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.a20Bombable = false;
        }
        //BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.b1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.b2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.b3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.b4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.b5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.b6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.b7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.b8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.b9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.b10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.b11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.b12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.b13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.b14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -616
             && gameObject.transform.localPosition.x <= -562
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.b15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.b16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.b17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.b18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.b19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -616
            && gameObject.transform.localPosition.x <= -562
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.b20Bombable = false;
        }
        //CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.c1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.c2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.c3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.c4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.c5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.c6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.c7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.c8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.c9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.c10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.c11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.c12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.c13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.c14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.c15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.c16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.c17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.c18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.c19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -561
            && gameObject.transform.localPosition.x <= -506
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.c20Bombable = false;
        }
        //DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.d1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.d2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.d3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.d4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.d5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.d6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.d7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -506
             && gameObject.transform.localPosition.x <= -451
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.d8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.d9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.d10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.d11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -506
             && gameObject.transform.localPosition.x <= -451
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.d12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.d13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.d14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.d15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.d16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.d17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.d18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.d19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -506
            && gameObject.transform.localPosition.x <= -451
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.d20Bombable = false;
        }
        //EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.e1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.e2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.e3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.e4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.e5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.e6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.e7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.e8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.e9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.e10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.e11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.e12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.e13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.e14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.e15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.e16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.e17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.e18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.e19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -451
            && gameObject.transform.localPosition.x <= -395
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.e20Bombable = false;
        }
        //FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.f1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.f2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.f3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.f4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.f5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.f6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.f7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.f8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.f9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.f10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.f11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.f12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.f13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.f14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.f15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.f16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.f17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.f18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.f19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -395
            && gameObject.transform.localPosition.x <= -340
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.f20Bombable = false;
        }
        //GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.g1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.g2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.g3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.g4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.g5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.g6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.g7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.g8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.g9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.g10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.g11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.g12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.g13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.g14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.g15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.g16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.g17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.g18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.g19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -340
            && gameObject.transform.localPosition.x <= -284
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.g20Bombable = false;
        }
        //HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.h1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.h2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.h3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.h4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.h5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.h6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.h7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.h8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.h9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.h10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.h11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.h12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.h13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.h14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.h15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.h16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.h17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.h18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.h19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -284
            && gameObject.transform.localPosition.x <= -228
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.h20Bombable = false;
        }
        //IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.i1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.i2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.i3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.i4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.i5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.i6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.i7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.i8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.i9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.i10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.i11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.i12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.i13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.i14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.i15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.i16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.i17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.i18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.i19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -228
            && gameObject.transform.localPosition.x <= -173
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.i20Bombable = false;
        }
        //JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.j1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.j2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.j3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.j4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.j5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.j6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.j7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.j8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.j9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.j10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.j11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.j12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.j13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.j14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.j15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.j16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.j17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.j18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.j19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -173
            && gameObject.transform.localPosition.x <= -117
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.j20Bombable = false;
        }
        //KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.k1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.k2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.k3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.k4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.k5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.k6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.k7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.k8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.k9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.k10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.k11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.k12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.k13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.k14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.k15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.k16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.k17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.k18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.k19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -117
            && gameObject.transform.localPosition.x <= -61
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.k20Bombable = false;
        }
        //LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.l1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.l2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.l3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.l4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.l5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.l6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.l7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.l8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.l9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.l10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.l11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.l12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.l13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.l14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.l15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.l16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.l17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.l18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.l19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -61
            && gameObject.transform.localPosition.x <= -5
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.l20Bombable = false;
        }
        //MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.m1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.m2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.m3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.m4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.m5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.m6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.m7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.m8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.m9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.m10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.m11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.m12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.m13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.m14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.m15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.m16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.m17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.m18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.m19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= -5
            && gameObject.transform.localPosition.x <= 50
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.m20Bombable = false;
        }
        //NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.n1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.n2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.n3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.n4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.n5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.n6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.n7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.n8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.n9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.n10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.n11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.n12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.n13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.n14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.n15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.n16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.n17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.n18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.n19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 50
            && gameObject.transform.localPosition.x <= 105
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.n20Bombable = false;
        }
        //OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.o1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.o2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.o3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.o4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.o5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.o6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.o7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.o8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.o9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.o10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.o11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.o12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.o13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.o14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.o15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.o16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.o17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.o18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.o19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 105
            && gameObject.transform.localPosition.x <= 161
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.o20Bombable = false;
        }
        //PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP

        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.p1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.p2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.p3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.p4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.p5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.p6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.p7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.p8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.p9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.p10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.p11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.p12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.p13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.p14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.p15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.p16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.p17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.p18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.p19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 161
            && gameObject.transform.localPosition.x <= 215
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.p20Bombable = false;
        }
        //QQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQ
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.q1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.q2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.q3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.q4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.q5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.q6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.q7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.q8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.q9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.q10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.q11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.q12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.q13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.q14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.q15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.q16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.q17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.q18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.q19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 215
            && gameObject.transform.localPosition.x <= 272
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.q20Bombable = false;
        }
        //RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.r1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.r2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.r3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.r4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.r5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.r6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.r7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.r8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.r9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.r10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.r11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.r12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.r13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.r14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.r15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.r16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.r17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.r18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.r19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 272
            && gameObject.transform.localPosition.x <= 326
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.r20Bombable = false;
        }
        //SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.s1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.s2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.s3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.s4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.s5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.s6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.s7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.s8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.s9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.s10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.s11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.s12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.s13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.s14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.s15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.s16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.s17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.s18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.s19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 326
            && gameObject.transform.localPosition.x <= 382
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.s20Bombable = false;
        }
        //TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.t1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.t2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.t3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.t4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.t5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.t6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.t7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.t8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.t9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.t10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.t11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.t12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.t13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.t14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.t15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.t16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.t17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.t18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.t19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 382
            && gameObject.transform.localPosition.x <= 438
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.t20Bombable = false;
        }
        //UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.u1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.u2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.u3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.u4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.u5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.u6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.u7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.u8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.u9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.u10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.u11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.u12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.u13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.u14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.u15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.u16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.u17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.u18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.u19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 438
            && gameObject.transform.localPosition.x <= 494
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.u20Bombable = false;
        }
        //VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV

        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.v1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.v2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.v3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.v4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.v5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.v6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.v7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.v8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.v9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.v10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.v11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.v12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.v13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.v14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.v15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.v16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.v17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.v18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.v19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 494
            && gameObject.transform.localPosition.x <= 550
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.v20Bombable = false;
        }
        //WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.w1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.w2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.w3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.w4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.w5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.w6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.w7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.w8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.w9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.w10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.w11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.w12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.w13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.w14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.w15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.w16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.w17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.w18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.w19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 550
            && gameObject.transform.localPosition.x <= 605
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.w20Bombable = false;
        }
        //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.x1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.x2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.x3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.x4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.x5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.x6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.x7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.x8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.x9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.x10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.x11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.x12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.x13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.x14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.x15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.x16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.x17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.x18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.x19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 605
            && gameObject.transform.localPosition.x <= 661
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.x20Bombable = false;
        }
        //YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= 413
            && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.y1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.y2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.y3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.y4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.y5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.y6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.y7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.y8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.y9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.y10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.y11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.y12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.y13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.y14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.y15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.y16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.y17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.y18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.y19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 661
            && gameObject.transform.localPosition.x <= 716
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.y20Bombable = false;
        }
        //ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ
        if (gameObject.transform.localPosition.x >= 716
           && gameObject.transform.localPosition.x <= 772
           && gameObject.transform.localPosition.y >= 413
           && gameObject.transform.localPosition.y <= 462)
        {
            coordinates.z1Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= 364
            && gameObject.transform.localPosition.y <= 413)
        {
            coordinates.z2Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= 315
            && gameObject.transform.localPosition.y <= 364)
        {
            coordinates.z3Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= 266
            && gameObject.transform.localPosition.y <= 315)
        {
            coordinates.z4Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= 218
            && gameObject.transform.localPosition.y <= 266)
        {
            coordinates.z5Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= 169
            && gameObject.transform.localPosition.y <= 218)
        {
            coordinates.z6Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= 120
            && gameObject.transform.localPosition.y <= 169)
        {
            coordinates.z7Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
             && gameObject.transform.localPosition.y >= 72
            && gameObject.transform.localPosition.y <= 120)
        {
            coordinates.z8Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= 23
            && gameObject.transform.localPosition.y <= 72)
        {
            coordinates.z9Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= -26
            && gameObject.transform.localPosition.y <= 23)
        {
            coordinates.z10Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= -74
            && gameObject.transform.localPosition.y <= -26)
        {
            coordinates.z11Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
             && gameObject.transform.localPosition.y >= -123
            && gameObject.transform.localPosition.y <= -74)
        {
            coordinates.z12Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= -172
            && gameObject.transform.localPosition.y <= -123)
        {
            coordinates.z13Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= -221
            && gameObject.transform.localPosition.y <= -172)
        {
            coordinates.z14Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
             && gameObject.transform.localPosition.y >= -270
            && gameObject.transform.localPosition.y <= -221)
        {
            coordinates.z15Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= -319
            && gameObject.transform.localPosition.y <= -270)
        {
            coordinates.z16Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= -367
            && gameObject.transform.localPosition.y <= -319)
        {
            coordinates.z17Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= -416
            && gameObject.transform.localPosition.y <= -367)
        {
            coordinates.z18Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= -464
            && gameObject.transform.localPosition.y <= -416)
        {
            coordinates.z19Bombable = false;
        }
        if (gameObject.transform.localPosition.x >= 716
            && gameObject.transform.localPosition.x <= 772
            && gameObject.transform.localPosition.y >= -513
            && gameObject.transform.localPosition.y <= -464)
        {
            coordinates.z20Bombable = false;
        }

    }
    */
}
