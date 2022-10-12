using System;
using System.Text;
using UnityEngine;
//WebGL// 
///*
using UnityEngine.Windows.Speech;
//*/
using UnityEngine.UI;
using System.Collections;
using TMPro;
using Random = UnityEngine.Random;

public class listener : MonoBehaviour
{
    public bombingControls bomb;

    public GameObject todayFriendly;
    public GameObject todayEnemy;
    public GameObject todayCivilian;
    public GameObject totalFriendly;
    public GameObject totalEnemy;
    public GameObject totalCivilian;

    public GameObject markConfines;
    public RectTransform confinesRect;

    public bool a1Bombable = false;
    public bool a2Bombable = false;
    public bool a3Bombable = false;
    public bool a4Bombable = false;
    public bool a5Bombable = false;
    public bool a6Bombable = false;
    public bool a7Bombable = false;
    public bool a8Bombable = false;
    public bool a9Bombable = false;
    public bool a10Bombable = false;
    public bool a11Bombable = false;
    public bool a12Bombable = false;
    public bool a13Bombable = false;
    public bool a14Bombable = false;
    public bool a15Bombable = false;
    public bool a16Bombable = false;
    public bool a17Bombable = false;
    public bool a18Bombable = false;
    public bool a19Bombable = false;
    public bool a20Bombable = false;
    public bool b1Bombable = false;
    public bool b2Bombable = false;
    public bool b3Bombable = false;
    public bool b4Bombable = false;
    public bool b5Bombable = false;
    public bool b6Bombable = false;
    public bool b7Bombable = false;
    public bool b8Bombable = false;
    public bool b9Bombable = false;
    public bool b10Bombable = false;
    public bool b11Bombable = false;
    public bool b12Bombable = false;
    public bool b13Bombable = false;
    public bool b14Bombable = false;
    public bool b15Bombable = false;
    public bool b16Bombable = false;
    public bool b17Bombable = false;
    public bool b18Bombable = false;
    public bool b19Bombable = false;
    public bool b20Bombable = false;
    public bool c1Bombable = false;
    public bool c2Bombable = false;
    public bool c3Bombable = false;
    public bool c4Bombable = false;
    public bool c5Bombable = false;
    public bool c6Bombable = false;
    public bool c7Bombable = false;
    public bool c8Bombable = false;
    public bool c9Bombable = false;
    public bool c10Bombable = false;
    public bool c11Bombable = false;
    public bool c12Bombable = false;
    public bool c13Bombable = false;
    public bool c14Bombable = false;
    public bool c15Bombable = false;
    public bool c16Bombable = false;
    public bool c17Bombable = false;
    public bool c18Bombable = false;
    public bool c19Bombable = false;
    public bool c20Bombable = false;
    public bool d1Bombable = false;
    public bool d2Bombable = false;
    public bool d3Bombable = false;
    public bool d4Bombable = false;
    public bool d5Bombable = false;
    public bool d6Bombable = false;
    public bool d7Bombable = false;
    public bool d8Bombable = false;
    public bool d9Bombable = false;
    public bool d10Bombable = false;
    public bool d11Bombable = false;
    public bool d12Bombable = false;
    public bool d13Bombable = false;
    public bool d14Bombable = false;
    public bool d15Bombable = false;
    public bool d16Bombable = false;
    public bool d17Bombable = false;
    public bool d18Bombable = false;
    public bool d19Bombable = false;
    public bool d20Bombable = false;
    public bool e1Bombable = false;
    public bool e2Bombable = false;
    public bool e3Bombable = false;
    public bool e4Bombable = false;
    public bool e5Bombable = false;
    public bool e6Bombable = false;
    public bool e7Bombable = false;
    public bool e8Bombable = false;
    public bool e9Bombable = false;
    public bool e10Bombable = false;
    public bool e11Bombable = false;
    public bool e12Bombable = false;
    public bool e13Bombable = false;
    public bool e14Bombable = false;
    public bool e15Bombable = false;
    public bool e16Bombable = false;
    public bool e17Bombable = false;
    public bool e18Bombable = false;
    public bool e19Bombable = false;
    public bool e20Bombable = false;
    public bool f1Bombable = false;
    public bool f2Bombable = false;
    public bool f3Bombable = false;
    public bool f4Bombable = false;
    public bool f5Bombable = false;
    public bool f6Bombable = false;
    public bool f7Bombable = false;
    public bool f8Bombable = false;
    public bool f9Bombable = false;
    public bool f10Bombable = false;
    public bool f11Bombable = false;
    public bool f12Bombable = false;
    public bool f13Bombable = false;
    public bool f14Bombable = false;
    public bool f15Bombable = false;
    public bool f16Bombable = false;
    public bool f17Bombable = false;
    public bool f18Bombable = false;
    public bool f19Bombable = false;
    public bool f20Bombable = false;
    public bool g1Bombable = false;
    public bool g2Bombable = false;
    public bool g3Bombable = false;
    public bool g4Bombable = false;
    public bool g5Bombable = false;
    public bool g6Bombable = false;
    public bool g7Bombable = false;
    public bool g8Bombable = false;
    public bool g9Bombable = false;
    public bool g10Bombable = false;
    public bool g11Bombable = false;
    public bool g12Bombable = false;
    public bool g13Bombable = false;
    public bool g14Bombable = false;
    public bool g15Bombable = false;
    public bool g16Bombable = false;
    public bool g17Bombable = false;
    public bool g18Bombable = false;
    public bool g19Bombable = false;
    public bool g20Bombable = false;
    public bool h1Bombable = false;
    public bool h2Bombable = false;
    public bool h3Bombable = false;
    public bool h4Bombable = false;
    public bool h5Bombable = false;
    public bool h6Bombable = false;
    public bool h7Bombable = false;
    public bool h8Bombable = false;
    public bool h9Bombable = false;
    public bool h10Bombable = false;
    public bool h11Bombable = false;
    public bool h12Bombable = false;
    public bool h13Bombable = false;
    public bool h14Bombable = false;
    public bool h15Bombable = false;
    public bool h16Bombable = false;
    public bool h17Bombable = false;
    public bool h18Bombable = false;
    public bool h19Bombable = false;
    public bool h20Bombable = false;
    public bool i1Bombable = false;
    public bool i2Bombable = false;
    public bool i3Bombable = false;
    public bool i4Bombable = false;
    public bool i5Bombable = false;
    public bool i6Bombable = false;
    public bool i7Bombable = false;
    public bool i8Bombable = false;
    public bool i9Bombable = false;
    public bool i10Bombable = false;
    public bool i11Bombable = false;
    public bool i12Bombable = false;
    public bool i13Bombable = false;
    public bool i14Bombable = false;
    public bool i15Bombable = false;
    public bool i16Bombable = false;
    public bool i17Bombable = false;
    public bool i18Bombable = false;
    public bool i19Bombable = false;
    public bool i20Bombable = false;
    public bool j1Bombable = false;
    public bool j2Bombable = false;
    public bool j3Bombable = false;
    public bool j4Bombable = false;
    public bool j5Bombable = false;
    public bool j6Bombable = false;
    public bool j7Bombable = false;
    public bool j8Bombable = false;
    public bool j9Bombable = false;
    public bool j10Bombable = false;
    public bool j11Bombable = false;
    public bool j12Bombable = false;
    public bool j13Bombable = false;
    public bool j14Bombable = false;
    public bool j15Bombable = false;
    public bool j16Bombable = false;
    public bool j17Bombable = false;
    public bool j18Bombable = false;
    public bool j19Bombable = false;
    public bool j20Bombable = false;
    public bool k1Bombable = false;
    public bool k2Bombable = false;
    public bool k3Bombable = false;
    public bool k4Bombable = false;
    public bool k5Bombable = false;
    public bool k6Bombable = false;
    public bool k7Bombable = false;
    public bool k8Bombable = false;
    public bool k9Bombable = false;
    public bool k10Bombable = false;
    public bool k11Bombable = false;
    public bool k12Bombable = false;
    public bool k13Bombable = false;
    public bool k14Bombable = false;
    public bool k15Bombable = false;
    public bool k16Bombable = false;
    public bool k17Bombable = false;
    public bool k18Bombable = false;
    public bool k19Bombable = false;
    public bool k20Bombable = false;
    public bool l1Bombable = false;
    public bool l2Bombable = false;
    public bool l3Bombable = false;
    public bool l4Bombable = false;
    public bool l5Bombable = false;
    public bool l6Bombable = false;
    public bool l7Bombable = false;
    public bool l8Bombable = false;
    public bool l9Bombable = false;
    public bool l10Bombable = false;
    public bool l11Bombable = false;
    public bool l12Bombable = false;
    public bool l13Bombable = false;
    public bool l14Bombable = false;
    public bool l15Bombable = false;
    public bool l16Bombable = false;
    public bool l17Bombable = false;
    public bool l18Bombable = false;
    public bool l19Bombable = false;
    public bool l20Bombable = false;
    public bool m1Bombable = false;
    public bool m2Bombable = false;
    public bool m3Bombable = false;
    public bool m4Bombable = false;
    public bool m5Bombable = false;
    public bool m6Bombable = false;
    public bool m7Bombable = false;
    public bool m8Bombable = false;
    public bool m9Bombable = false;
    public bool m10Bombable = false;
    public bool m11Bombable = false;
    public bool m12Bombable = false;
    public bool m13Bombable = false;
    public bool m14Bombable = false;
    public bool m15Bombable = false;
    public bool m16Bombable = false;
    public bool m17Bombable = false;
    public bool m18Bombable = false;
    public bool m19Bombable = false;
    public bool m20Bombable = false;
    public bool n1Bombable = false;
    public bool n2Bombable = false;
    public bool n3Bombable = false;
    public bool n4Bombable = false;
    public bool n5Bombable = false;
    public bool n6Bombable = false;
    public bool n7Bombable = false;
    public bool n8Bombable = false;
    public bool n9Bombable = false;
    public bool n10Bombable = false;
    public bool n11Bombable = false;
    public bool n12Bombable = false;
    public bool n13Bombable = false;
    public bool n14Bombable = false;
    public bool n15Bombable = false;
    public bool n16Bombable = false;
    public bool n17Bombable = false;
    public bool n18Bombable = false;
    public bool n19Bombable = false;
    public bool n20Bombable = false;
    public bool o1Bombable = false;
    public bool o2Bombable = false;
    public bool o3Bombable = false;
    public bool o4Bombable = false;
    public bool o5Bombable = false;
    public bool o6Bombable = false;
    public bool o7Bombable = false;
    public bool o8Bombable = false;
    public bool o9Bombable = false;
    public bool o10Bombable = false;
    public bool o11Bombable = false;
    public bool o12Bombable = false;
    public bool o13Bombable = false;
    public bool o14Bombable = false;
    public bool o15Bombable = false;
    public bool o16Bombable = false;
    public bool o17Bombable = false;
    public bool o18Bombable = false;
    public bool o19Bombable = false;
    public bool o20Bombable = false;
    public bool p1Bombable = false;
    public bool p2Bombable = false;
    public bool p3Bombable = false;
    public bool p4Bombable = false;
    public bool p5Bombable = false;
    public bool p6Bombable = false;
    public bool p7Bombable = false;
    public bool p8Bombable = false;
    public bool p9Bombable = false;
    public bool p10Bombable = false;
    public bool p11Bombable = false;
    public bool p12Bombable = false;
    public bool p13Bombable = false;
    public bool p14Bombable = false;
    public bool p15Bombable = false;
    public bool p16Bombable = false;
    public bool p17Bombable = false;
    public bool p18Bombable = false;
    public bool p19Bombable = false;
    public bool p20Bombable = false;
    public bool q1Bombable = false;
    public bool q2Bombable = false;
    public bool q3Bombable = false;
    public bool q4Bombable = false;
    public bool q5Bombable = false;
    public bool q6Bombable = false;
    public bool q7Bombable = false;
    public bool q8Bombable = false;
    public bool q9Bombable = false;
    public bool q10Bombable = false;
    public bool q11Bombable = false;
    public bool q12Bombable = false;
    public bool q13Bombable = false;
    public bool q14Bombable = false;
    public bool q15Bombable = false;
    public bool q16Bombable = false;
    public bool q17Bombable = false;
    public bool q18Bombable = false;
    public bool q19Bombable = false;
    public bool q20Bombable = false;
    public bool r1Bombable = false;
    public bool r2Bombable = false;
    public bool r3Bombable = false;
    public bool r4Bombable = false;
    public bool r5Bombable = false;
    public bool r6Bombable = false;
    public bool r7Bombable = false;
    public bool r8Bombable = false;
    public bool r9Bombable = false;
    public bool r10Bombable = false;
    public bool r11Bombable = false;
    public bool r12Bombable = false;
    public bool r13Bombable = false;
    public bool r14Bombable = false;
    public bool r15Bombable = false;
    public bool r16Bombable = false;
    public bool r17Bombable = false;
    public bool r18Bombable = false;
    public bool r19Bombable = false;
    public bool r20Bombable = false;
    public bool s1Bombable = false;
    public bool s2Bombable = false;
    public bool s3Bombable = false;
    public bool s4Bombable = false;
    public bool s5Bombable = false;
    public bool s6Bombable = false;
    public bool s7Bombable = false;
    public bool s8Bombable = false;
    public bool s9Bombable = false;
    public bool s10Bombable = false;
    public bool s11Bombable = false;
    public bool s12Bombable = false;
    public bool s13Bombable = false;
    public bool s14Bombable = false;
    public bool s15Bombable = false;
    public bool s16Bombable = false;
    public bool s17Bombable = false;
    public bool s18Bombable = false;
    public bool s19Bombable = false;
    public bool s20Bombable = false;
    public bool t1Bombable = false;
    public bool t2Bombable = false;
    public bool t3Bombable = false;
    public bool t4Bombable = false;
    public bool t5Bombable = false;
    public bool t6Bombable = false;
    public bool t7Bombable = false;
    public bool t8Bombable = false;
    public bool t9Bombable = false;
    public bool t10Bombable = false;
    public bool t11Bombable = false;
    public bool t12Bombable = false;
    public bool t13Bombable = false;
    public bool t14Bombable = false;
    public bool t15Bombable = false;
    public bool t16Bombable = false;
    public bool t17Bombable = false;
    public bool t18Bombable = false;
    public bool t19Bombable = false;
    public bool t20Bombable = false;
    public bool u1Bombable = false;
    public bool u2Bombable = false;
    public bool u3Bombable = false;
    public bool u4Bombable = false;
    public bool u5Bombable = false;
    public bool u6Bombable = false;
    public bool u7Bombable = false;
    public bool u8Bombable = false;
    public bool u9Bombable = false;
    public bool u10Bombable = false;
    public bool u11Bombable = false;
    public bool u12Bombable = false;
    public bool u13Bombable = false;
    public bool u14Bombable = false;
    public bool u15Bombable = false;
    public bool u16Bombable = false;
    public bool u17Bombable = false;
    public bool u18Bombable = false;
    public bool u19Bombable = false;
    public bool u20Bombable = false;
    public bool v1Bombable = false;
    public bool v2Bombable = false;
    public bool v3Bombable = false;
    public bool v4Bombable = false;
    public bool v5Bombable = false;
    public bool v6Bombable = false;
    public bool v7Bombable = false;
    public bool v8Bombable = false;
    public bool v9Bombable = false;
    public bool v10Bombable = false;
    public bool v11Bombable = false;
    public bool v12Bombable = false;
    public bool v13Bombable = false;
    public bool v14Bombable = false;
    public bool v15Bombable = false;
    public bool v16Bombable = false;
    public bool v17Bombable = false;
    public bool v18Bombable = false;
    public bool v19Bombable = false;
    public bool v20Bombable = false;
    public bool w1Bombable = false;
    public bool w2Bombable = false;
    public bool w3Bombable = false;
    public bool w4Bombable = false;
    public bool w5Bombable = false;
    public bool w6Bombable = false;
    public bool w7Bombable = false;
    public bool w8Bombable = false;
    public bool w9Bombable = false;
    public bool w10Bombable = false;
    public bool w11Bombable = false;
    public bool w12Bombable = false;
    public bool w13Bombable = false;
    public bool w14Bombable = false;
    public bool w15Bombable = false;
    public bool w16Bombable = false;
    public bool w17Bombable = false;
    public bool w18Bombable = false;
    public bool w19Bombable = false;
    public bool w20Bombable = false;
    public bool x1Bombable = false;
    public bool x2Bombable = false;
    public bool x3Bombable = false;
    public bool x4Bombable = false;
    public bool x5Bombable = false;
    public bool x6Bombable = false;
    public bool x7Bombable = false;
    public bool x8Bombable = false;
    public bool x9Bombable = false;
    public bool x10Bombable = false;
    public bool x11Bombable = false;
    public bool x12Bombable = false;
    public bool x13Bombable = false;
    public bool x14Bombable = false;
    public bool x15Bombable = false;
    public bool x16Bombable = false;
    public bool x17Bombable = false;
    public bool x18Bombable = false;
    public bool x19Bombable = false;
    public bool x20Bombable = false;
    public bool y1Bombable = false;
    public bool y2Bombable = false;
    public bool y3Bombable = false;
    public bool y4Bombable = false;
    public bool y5Bombable = false;
    public bool y6Bombable = false;
    public bool y7Bombable = false;
    public bool y8Bombable = false;
    public bool y9Bombable = false;
    public bool y10Bombable = false;
    public bool y11Bombable = false;
    public bool y12Bombable = false;
    public bool y13Bombable = false;
    public bool y14Bombable = false;
    public bool y15Bombable = false;
    public bool y16Bombable = false;
    public bool y17Bombable = false;
    public bool y18Bombable = false;
    public bool y19Bombable = false;
    public bool y20Bombable = false;
    public bool z1Bombable = false;
    public bool z2Bombable = false;
    public bool z3Bombable = false;
    public bool z4Bombable = false;
    public bool z5Bombable = false;
    public bool z6Bombable = false;
    public bool z7Bombable = false;
    public bool z8Bombable = false;
    public bool z9Bombable = false;
    public bool z10Bombable = false;
    public bool z11Bombable = false;
    public bool z12Bombable = false;
    public bool z13Bombable = false;
    public bool z14Bombable = false;
    public bool z15Bombable = false;
    public bool z16Bombable = false;
    public bool z17Bombable = false;
    public bool z18Bombable = false;
    public bool z19Bombable = false;
    public bool z20Bombable = false;

    public GameObject mark1;
    public GameObject mark2;
    public GameObject mark3;
    public GameObject mark4;
    public GameObject mark5;
    public GameObject mark6;
    public GameObject mark7;
    public GameObject mark8;
    public GameObject mark9;
    public GameObject mark10;
    public GameObject mark11;
    public GameObject mark12;

    public AudioSource bombHit1;
    public AudioSource bombHit2;
    public AudioSource bombHit3;
    public AudioSource bombHit4;
    public AudioSource bombHit5;
    public AudioSource bombHit6;
    public AudioSource bombHit7;
    public AudioSource bombHit8;
    public AudioSource bombHit9;
    public AudioSource bombHit10;

    public AudioSource yesVoice1;
    public AudioSource yesVoice2;
    public AudioSource yesVoice3;
    public AudioSource yesVoice4;
    public AudioSource yesVoice5;
    public AudioSource yesVoice6;
    public AudioSource yesVoice7;
    public AudioSource yesVoice8;
    public AudioSource yesVoice9;
    public AudioSource yesVoice10;
    public AudioSource yesVoice11;
    public AudioSource yesVoice12;
    public AudioSource yesVoice13;
    public AudioSource yesVoice14;
    public AudioSource yesVoice15;

    public AudioSource missVoice1;
    public AudioSource missVoice2;
    public AudioSource missVoice3;
    public AudioSource missVoice4;
    public AudioSource missVoice5;
    public AudioSource missVoice6;
    public AudioSource missVoice7;
    public AudioSource missVoice8;
    public AudioSource missVoice9;
    public AudioSource missVoice10;
    public AudioSource missVoice11;
    public AudioSource missVoice12;
    public AudioSource missVoice13;
    public AudioSource missVoice14;
    public AudioSource missVoice15;
    public AudioSource missVoice16;
    public AudioSource missVoice17;
    public AudioSource missVoice18;
    public AudioSource missVoice19;
    public AudioSource missVoice20;
    public AudioSource missVoice21;
    public AudioSource missVoice22;
    public AudioSource missVoice23;

    [SerializeField]
    private string[] m_Keywords;

     //WebGL// 
     ///*
     private KeywordRecognizer m_Recognizer;
    //*/
    void Start()
    {
        confinesRect = markConfines.GetComponent<RectTransform>();
        //WebGL//
        ///*
         m_Recognizer = new KeywordRecognizer(m_Keywords);
         m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
         m_Recognizer.Start();
         //*/
        //a1Bombable = false;
        //todayFriendly.GetComponent<TextMeshProUGUI>().text = "00000";
    }

    /*
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6))
        {
            PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A1");                
                

        }
        if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7))
        {
           PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();          
                

        }      
    }
    */
    
    //WebGL//
    ///*
    private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat("{0} ({1}){2}", args.text, args.confidence, Environment.NewLine);
        builder.AppendFormat("\tTimestamp: {0}{1}", args.phraseStartTime, Environment.NewLine);
        builder.AppendFormat("\tDuration: {0} seconds{1}", args.phraseDuration.TotalSeconds, Environment.NewLine);
        Debug.Log(builder.ToString());
        Debug.Log(args.text + args.confidence);

        //terminate this method/function at this point if bombing mode is not enabled
        if (bomb.bombing != true) return;

        switch (args.text)
        {
            case "alpha 1" when a1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A1");                
                break;
            case "alpha 1" when a1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "alpha 2" when a2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A2");
                break;
            case "alpha 2" when a2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "alpha 3" when a3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A3");
                break;
            case "alpha 3" when a3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "alpha 4" when a4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A4");
                break;
            case "alpha 4" when a4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "alpha 5" when a5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A5");
                break;
            case "alpha 5" when a5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "alpha 6" when a6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A6");
                break;
            case "alpha 6" when a6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "alpha 7" when a7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A7");
                break;
            case "alpha 7" when a7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "alpha 8" when a8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A8");
                break;
            case "alpha 8" when a8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "alpha 9" when a9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A9");
                break;
            case "alpha 9" when a9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "alpha 10" when a10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A10");
                break;
            case "alpha 10" when a10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "alpha 11" when a11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A11");
                break;
            case "alpha 11" when a11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "alpha 12" when a12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A12");
                break;
            case "alpha 12" when a12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "alpha 13" when a13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A13");
                break;
            case "alpha 13" when a13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "alpha 14" when a14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A14");
                break;
            case "alpha 14" when a14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "alpha 15" when a15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A15");
                break;
            case "alpha 15" when a15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "alpha 16" when a16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A16");
                break;
            case "alpha 16" when a16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "alpha 17" when a17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A17");
                break;
            case "alpha 17" when a17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "alpha 18" when a18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A18");
                break;
            case "alpha 18" when a18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "alpha 19" when a19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A19");
                break;
            case "alpha 19" when a19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "alpha 20" when a20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("A20");
                break;
            case "alpha 20" when a20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;

            //BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB

            case "bravo 1" when b1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("B1");
                break;
            case "bravo 1" when b1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "bravo 2" when b2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("B2");
                break;
            case "bravo 2" when b2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "bravo 3" when b3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("B3");
                break;
            case "bravo 3" when b3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "bravo 4" when b4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("B4");
                break;
            case "bravo 4" when b4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "bravo 5" when b5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("B5");
                break;
            case "bravo 5" when b5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "bravo 6" when b6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("B6");
                break;
            case "bravo 6" when b6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "bravo 7" when b7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("B7");
                break;
            case "bravo 7" when b7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "bravo 8" when b8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("B8");
                break;
            case "bravo 8" when b8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "bravo 9" when b9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("B9");
                break;
            case "bravo 9" when b9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "bravo 10" when b10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("B10");
                break;
            case "bravo 10" when b10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "bravo 11" when b11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("B11");
                break;
            case "bravo 11" when b11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "bravo 12" when b12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("B12");
                break;
            case "bravo 12" when b12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "bravo 13" when b13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("B13");
                break;
            case "bravo 13" when b13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "bravo 14" when b14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("B14");
                break;
            case "bravo 14" when b14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "bravo 15" when b15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("B15");
                break;
            case "bravo 15" when b15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "bravo 16" when b16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("B16");
                break;
            case "bravo 16" when b16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "bravo 17" when b17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("B17");
                break;
            case "bravo 17" when b17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "bravo 18" when b18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("B18");
                break;
            case "bravo 18" when b18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "bravo 19" when b19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("B19");
                break;
            case "bravo 19" when b19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "bravo 20" when b20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("B20");
                break;
            case "bravo 20" when b20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC
            case "charlie 1" when c1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("C1");
                break;
            case "charlie 1" when c1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "charlie 2" when c2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("C2");
                break;
            case "charlie 2" when c2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "charlie 3" when c3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("C3");
                break;
            case "charlie 3" when c3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "charlie 4" when c4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("C4");
                break;
            case "charlie 4" when c4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "charlie 5" when c5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("C5");
                break;
            case "charlie 5" when c5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "charlie 6" when c6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("C6");
                break;
            case "charlie 6" when c6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "charlie 7" when c7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("C7");
                break;
            case "charlie 7" when c7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "charlie 8" when c8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("C8");
                break;
            case "charlie 8" when c8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "charlie 9" when c9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("C9");
                break;
            case "charlie 9" when c9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "charlie 10" when c10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("C10");
                break;
            case "charlie 10" when c10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "charlie 11" when c11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("C11");
                break;
            case "charlie 11" when c11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "charlie 12" when c12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("C12");
                break;
            case "charlie 12" when c12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "charlie 13" when c13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("C13");
                break;
            case "charlie 13" when c13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "charlie 14" when c14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("C14");
                break;
            case "charlie 14" when c14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "charlie 15" when c15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("C15");
                break;
            case "charlie 15" when c15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "charlie 16" when c16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("C16");
                break;
            case "charlie 16" when c16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "charlie 17" when c17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("C17");
                break;
            case "charlie 17" when c17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "charlie 18" when c18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("C18");
                break;
            case "charlie 18" when c18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "charlie 19" when c19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("C19");
                break;
            case "charlie 19" when c19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "charlie 20" when c20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("C20");
                break;
            case "charlie 20" when c20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD
            case "delta 1" when d1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("D1");
                break;
            case "delta 1" when d1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "delta 2" when d2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("D2");
                break;
            case "delta 2" when d2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "delta 3" when d3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("D3");
                break;
            case "delta 3" when d3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "delta 4" when d4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("D4");
                break;
            case "delta 4" when d4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "delta 5" when d5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("D5");
                break;
            case "delta 5" when d5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "delta 6" when d6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("D6");
                break;
            case "delta 6" when d6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "delta 7" when d7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("D7");
                break;
            case "delta 7" when d7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "delta 8" when d8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("D8");
                break;
            case "delta 8" when d8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "delta 9" when d9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("D9");
                break;
            case "delta 9" when d9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "delta 10" when d10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("D10");
                break;
            case "delta 10" when d10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "delta 11" when d11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("D11");
                break;
            case "delta 11" when d11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "delta 12" when d12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("D12");
                break;
            case "delta 12" when d12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "delta 13" when d13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("D13");
                break;
            case "delta 13" when d13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "delta 14" when d14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("D14");
                break;
            case "delta 14" when d14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "delta 15" when d15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("D15");
                break;
            case "delta 15" when d15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "delta 16" when d16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("D16");
                break;
            case "delta 16" when d16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "delta 17" when d17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("D17");
                break;
            case "delta 17" when d17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "delta 18" when d18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("D18");
                break;
            case "delta 18" when d18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "delta 19" when d19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("D19");
                break;
            case "delta 19" when d19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "delta 20" when d20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("D20");
                break;
            case "delta 20" when d20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEe
            case "echo 1" when e1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("E1");
                break;
            case "echo 1" when e1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "echo 2" when e2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("E2");
                break;
            case "echo 2" when e2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "echo 3" when e3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("E3");
                break;
            case "echo 3" when e3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "echo 4" when e4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("E4");
                break;
            case "echo 4" when e4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "echo 5" when e5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("E5");
                break;
            case "echo 5" when e5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "echo 6" when e6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("E6");
                break;
            case "echo 6" when e6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "echo 7" when e7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("E7");
                break;
            case "echo 7" when e7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "echo 8" when e8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("E8");
                break;
            case "echo 8" when e8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "echo 9" when e9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("E9");
                break;
            case "echo 9" when e9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "echo 10" when e10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("E10");
                break;
            case "echo 10" when e10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "echo 11" when e11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("E11");
                break;
            case "echo 11" when e11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "echo 12" when e12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("E12");
                break;
            case "echo 12" when e12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "echo 13" when e13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("E13");
                break;
            case "echo 13" when e13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "echo 14" when e14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("E14");
                break;
            case "echo 14" when e14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "echo 15" when e15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("E15");
                break;
            case "echo 15" when e15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "echo 16" when e16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("E16");
                break;
            case "echo 16" when e16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "echo 17" when e17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("E17");
                break;
            case "echo 17" when e17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "echo 18" when e18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("E18");
                break;
            case "echo 18" when e18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "echo 19" when e19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("E19");
                break;
            case "echo 19" when e19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "echo 20" when e20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("E20");
                break;
            case "echo 20" when e20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
            case "foxtrot 1" when f1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("F1");
                break;
            case "foxtrot 1" when f1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "foxtrot 2" when f2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("F2");
                break;
            case "foxtrot 2" when f2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "foxtrot 3" when f3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("F3");
                break;
            case "foxtrot 3" when f3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "foxtrot 4" when f4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("F4");
                break;
            case "foxtrot 4" when f4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "foxtrot 5" when f5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("F5");
                break;
            case "foxtrot 5" when f5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "foxtrot 6" when f6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("F6");
                break;
            case "foxtrot 6" when f6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "foxtrot 7" when f7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("F7");
                break;
            case "foxtrot 7" when f7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "foxtrot 8" when f8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("F8");
                break;
            case "foxtrot 8" when f8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "foxtrot 9" when f9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("F9");
                break;
            case "foxtrot 9" when f9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "foxtrot 10" when f10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("F10");
                break;
            case "foxtrot 10" when f10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "foxtrot 11" when f11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("F11");
                break;
            case "foxtrot 11" when f11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "foxtrot 12" when f12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("F12");
                break;
            case "foxtrot 12" when f12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "foxtrot 13" when f13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("F13");
                break;
            case "foxtrot 13" when f13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "foxtrot 14" when f14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("F14");
                break;
            case "foxtrot 14" when f14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "foxtrot 15" when f15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("F15");
                break;
            case "foxtrot 15" when f15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "foxtrot 16" when f16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("F16");
                break;
            case "foxtrot 16" when f16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "foxtrot 17" when f17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("F17");
                break;
            case "foxtrot 17" when f17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "foxtrot 18" when f18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("F18");
                break;
            case "foxtrot 18" when f18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "foxtrot 19" when f19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("F19");
                break;
            case "foxtrot 19" when f19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "foxtrot 20" when f20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("F20");
                break;
            case "foxtrot 20" when f20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG
            case "golf 1" when g1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("G1");
                break;
            case "golf 1" when g1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "golf 2" when g2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("G2");
                break;
            case "golf 2" when g2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "golf 3" when g3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("G3");
                break;
            case "golf 3" when g3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "golf 4" when g4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("G4");
                break;
            case "golf 4" when g4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "golf 5" when g5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("G5");
                break;
            case "golf 5" when g5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "golf 6" when g6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("G6");
                break;
            case "golf 6" when g6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "golf 7" when g7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("G7");
                break;
            case "golf 7" when g7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "golf 8" when g8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("G8");
                break;
            case "golf 8" when g8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "golf 9" when g9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("G9");
                break;
            case "golf 9" when g9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "golf 10" when g10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("G10");
                break;
            case "golf 10" when g10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "golf 11" when g11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("G11");
                break;
            case "golf 11" when g11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "golf 12" when g12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("G12");
                break;
            case "golf 12" when g12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "golf 13" when g13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("G13");
                break;
            case "golf 13" when g13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "golf 14" when g14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("G14");
                break;
            case "golf 14" when g14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "golf 15" when g15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("G15");
                break;
            case "golf 15" when g15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "golf 16" when g16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("G16");
                break;
            case "golf 16" when g16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "golf 17" when g17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("G17");
                break;
            case "golf 17" when g17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "golf 18" when g18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("G18");
                break;
            case "golf 18" when g18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "golf 19" when g19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("G19");
                break;
            case "golf 19" when g19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "golf 20" when g20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("G20");
                break;
            case "golf 20" when g20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH
            case "hotel 1" when h1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("H1");
                break;
            case "hotel 1" when h1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "hotel 2" when h2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("H2");
                break;
            case "hotel 2" when h2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "hotel 3" when h3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("H3");
                break;
            case "hotel 3" when h3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "hotel 4" when h4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("H4");
                break;
            case "hotel 4" when h4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "hotel 5" when h5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("H5");
                break;
            case "hotel 5" when h5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "hotel 6" when h6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("H6");
                break;
            case "hotel 6" when h6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "hotel 7" when h7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("H7");
                break;
            case "hotel 7" when h7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "hotel 8" when h8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("H8");
                break;
            case "hotel 8" when h8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "hotel 9" when h9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("H9");
                break;
            case "hotel 9" when h9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "hotel 10" when h10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("H10");
                break;
            case "hotel 10" when h10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "hotel 11" when h11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("H11");
                break;
            case "hotel 11" when h11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "hotel 12" when h12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("H12");
                break;
            case "hotel 12" when h12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "hotel 13" when h13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("H13");
                break;
            case "hotel 13" when h13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "hotel 14" when h14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("H14");
                break;
            case "hotel 14" when h14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "hotel 15" when h15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("H15");
                break;
            case "hotel 15" when h15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "hotel 16" when h16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("H16");
                break;
            case "hotel 16" when h16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "hotel 17" when h17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("H17");
                break;
            case "hotel 17" when h17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "hotel 18" when h18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("H18");
                break;
            case "hotel 18" when h18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "hotel 19" when h19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("H19");
                break;
            case "hotel 19" when h19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "hotel 20" when h20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("H20");
                break;
            case "hotel 20" when h20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
            case "india 1" when i1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("I1");
                break;
            case "india 1" when i1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "india 2" when i2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("I2");
                break;
            case "india 2" when i2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "india 3" when i3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("I3");
                break;
            case "india 3" when i3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "india 4" when i4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("I4");
                break;
            case "india 4" when i4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "india 5" when i5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("I5");
                break;
            case "india 5" when i5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "india 6" when i6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("I6");
                break;
            case "india 6" when i6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "india 7" when i7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("I7");
                break;
            case "india 7" when i7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "india 8" when i8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("I8");
                break;
            case "india 8" when i8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "india 9" when i9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("I9");
                break;
            case "india 9" when i9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "india 10" when i10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("I10");
                break;
            case "india 10" when i10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "india 11" when i11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("I11");
                break;
            case "india 11" when i11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "india 12" when i12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("I12");
                break;
            case "india 12" when i12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "india 13" when i13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("I13");
                break;
            case "india 13" when i13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "india 14" when i14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("I14");
                break;
            case "india 14" when i14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "india 15" when i15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("I15");
                break;
            case "india 15" when i15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "india 16" when i16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("I16");
                break;
            case "india 16" when i16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "india 17" when i17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("I17");
                break;
            case "india 17" when i17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "india 18" when i18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("I18");
                break;
            case "india 18" when i18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "india 19" when i19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("I19");
                break;
            case "india 19" when i19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "india 20" when i20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("I20");
                break;
            case "india 20" when i20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ
            case "juliet 1" when j1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("J1");
                break;
            case "juliet 1" when j1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "juliet 2" when j2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("J2");
                break;
            case "juliet 2" when j2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "juliet 3" when j3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("J3");
                break;
            case "juliet 3" when j3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "juliet 4" when j4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("J4");
                break;
            case "juliet 4" when j4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "juliet 5" when j5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("J5");
                break;
            case "juliet 5" when j5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "juliet 6" when j6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("J6");
                break;
            case "juliet 6" when j6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "juliet 7" when j7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("J7");
                break;
            case "juliet 7" when j7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "juliet 8" when j8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("J8");
                break;
            case "juliet 8" when j8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "juliet 9" when j9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("J9");
                break;
            case "juliet 9" when j9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "juliet 10" when j10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("J10");
                break;
            case "juliet 10" when j10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "juliet 11" when j11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("J11");
                break;
            case "juliet 11" when j11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "juliet 12" when j12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("J12");
                break;
            case "juliet 12" when j12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "juliet 13" when j13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("J13");
                break;
            case "juliet 13" when j13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "juliet 14" when j14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("J14");
                break;
            case "juliet 14" when j14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "juliet 15" when j15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("J15");
                break;
            case "juliet 15" when j15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "juliet 16" when j16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("J16");
                break;
            case "juliet 16" when j16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "juliet 17" when j17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("J17");
                break;
            case "juliet 17" when j17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "juliet 18" when j18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("J18");
                break;
            case "juliet 18" when j18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "juliet 19" when j19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("J19");
                break;
            case "juliet 19" when j19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "juliet 20" when j20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("J20");
                break;
            case "juliet 20" when j20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK
            case "kilo 1" when k1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("K1");
                break;
            case "kilo 1" when k1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "kilo 2" when k2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("K2");
                break;
            case "kilo 2" when k2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "kilo 3" when k3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("K3");
                break;
            case "kilo 3" when k3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "kilo 4" when k4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("K4");
                break;
            case "kilo 4" when k4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "kilo 5" when k5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("K5");
                break;
            case "kilo 5" when k5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "kilo 6" when k6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("K6");
                break;
            case "kilo 6" when k6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "kilo 7" when k7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("K7");
                break;
            case "kilo 7" when k7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "kilo 8" when k8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("K8");
                break;
            case "kilo 8" when k8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "kilo 9" when k9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("K9");
                break;
            case "kilo 9" when k9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "kilo 10" when k10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("K10");
                break;
            case "kilo 10" when k10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "kilo 11" when k11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("K11");
                break;
            case "kilo 11" when k11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "kilo 12" when k12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("K12");
                break;
            case "kilo 12" when k12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "kilo 13" when k13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("K13");
                break;
            case "kilo 13" when k13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "kilo 14" when k14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("K14");
                break;
            case "kilo 14" when k14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "kilo 15" when k15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("K15");
                break;
            case "kilo 15" when k15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "kilo 16" when k16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("K16");
                break;
            case "kilo 16" when k16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "kilo 17" when k17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("K17");
                break;
            case "kilo 17" when k17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "kilo 18" when k18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("K18");
                break;
            case "kilo 18" when k18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "kilo 19" when k19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("K19");
                break;
            case "kilo 19" when k19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "kilo 20" when k20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("K20");
                break;
            case "kilo 20" when k20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL
            case "lima 1" when l1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("L1");
                break;
            case "lima 1" when l1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "lima 2" when l2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("L2");
                break;
            case "lima 2" when l2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "lima 3" when l3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("L3");
                break;
            case "lima 3" when l3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "lima 4" when l4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("L4");
                break;
            case "lima 4" when l4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "lima 5" when l5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("L5");
                break;
            case "lima 5" when l5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "lima 6" when l6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("L6");
                break;
            case "lima 6" when l6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "lima 7" when l7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("L7");
                break;
            case "lima 7" when l7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "lima 8" when l8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("L8");
                break;
            case "lima 8" when l8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "lima 9" when l9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("L9");
                break;
            case "lima 9" when l9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "lima 10" when l10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("L10");
                break;
            case "lima 10" when l10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "lima 11" when l11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("L11");
                break;
            case "lima 11" when l11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "lima 12" when l12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("L12");
                break;
            case "lima 12" when l12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "lima 13" when l13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("L13");
                break;
            case "lima 13" when l13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "lima 14" when l14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("L14");
                break;
            case "lima 14" when l14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "lima 15" when l15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("L15");
                break;
            case "lima 15" when l15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "lima 16" when l16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("L16");
                break;
            case "lima 16" when l16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "lima 17" when l17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("L17");
                break;
            case "lima 17" when l17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "lima 18" when l18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("L18");
                break;
            case "lima 18" when l18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "lima 19" when l19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("L19");
                break;
            case "lima 19" when l19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "lima 20" when l20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("L20");
                break;
            case "lima 20" when l20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
            case "mike 1" when m1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("M1");
                break;
            case "mike 1" when m1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "mike 2" when m2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("M2");
                break;
            case "mike 2" when m2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "mike 3" when m3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("M3");
                break;
            case "mike 3" when m3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "mike 4" when m4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("M4");
                break;
            case "mike 4" when m4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "mike 5" when m5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("M5");
                break;
            case "mike 5" when m5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "mike 6" when m6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("M6");
                break;
            case "mike 6" when m6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "mike 7" when m7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("M7");
                break;
            case "mike 7" when m7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "mike 8" when m8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("M8");
                break;
            case "mike 8" when m8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "mike 9" when m9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("M9");
                break;
            case "mike 9" when m9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "mike 10" when m10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("M10");
                break;
            case "mike 10" when m10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "mike 11" when m11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("M11");
                break;
            case "mike 11" when m11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "mike 12" when m12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("M12");
                break;
            case "mike 12" when m12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "mike 13" when m13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("M13");
                break;
            case "mike 13" when m13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "mike 14" when m14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("M14");
                break;
            case "mike 14" when m14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "mike 15" when m15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("M15");
                break;
            case "mike 15" when m15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "mike 16" when m16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("M16");
                break;
            case "mike 16" when m16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "mike 17" when m17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("M17");
                break;
            case "mike 17" when m17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "mike 18" when m18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("M18");
                break;
            case "mike 18" when m18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "mike 19" when m19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("M19");
                break;
            case "mike 19" when m19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "mike 20" when m20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("M20");
                break;
            case "mike 20" when m20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
            case "november 1" when n1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("N1");
                break;
            case "november 1" when n1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "november 2" when n2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("N2");
                break;
            case "november 2" when n2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "november 3" when n3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("N3");
                break;
            case "november 3" when n3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "november 4" when n4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("N4");
                break;
            case "november 4" when n4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "november 5" when n5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("N5");
                break;
            case "november 5" when n5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "november 6" when n6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("N6");
                break;
            case "november 6" when n6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "november 7" when n7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("N7");
                break;
            case "november 7" when n7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "november 8" when n8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("N8");
                break;
            case "november 8" when n8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "november 9" when n9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("N9");
                break;
            case "november 9" when n9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "november 10" when n10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("N10");
                break;
            case "november 10" when n10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "november 11" when n11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("N11");
                break;
            case "november 11" when n11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "november 12" when n12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("N12");
                break;
            case "november 12" when n12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "november 13" when n13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("N13");
                break;
            case "november 13" when n13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "november 14" when n14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("N14");
                break;
            case "november 14" when n14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "november 15" when n15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("N15");
                break;
            case "november 15" when n15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "november 16" when n16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("N16");
                break;
            case "november 16" when n16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "november 17" when n17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("N17");
                break;
            case "november 17" when n17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "november 18" when n18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("N18");
                break;
            case "november 18" when n18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "november 19" when n19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("N19");
                break;
            case "november 19" when n19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "november 20" when n20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("N20");
                break;
            case "november 20" when n20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
            case "oscar 1" when o1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("O1");
                break;
            case "oscar 1" when o1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "oscar 2" when o2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("O2");
                break;
            case "oscar 2" when o2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "oscar 3" when o3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("O3");
                break;
            case "oscar 3" when o3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "oscar 4" when o4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("O4");
                break;
            case "oscar 4" when o4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "oscar 5" when o5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("O5");
                break;
            case "oscar 5" when o5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "oscar 6" when o6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("O6");
                break;
            case "oscar 6" when o6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "oscar 7" when o7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("O7");
                break;
            case "oscar 7" when o7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "oscar 8" when o8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("O8");
                break;
            case "oscar 8" when o8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "oscar 9" when o9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("O9");
                break;
            case "oscar 9" when o9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "oscar 10" when o10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("O10");
                break;
            case "oscar 10" when o10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "oscar 11" when o11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("O11");
                break;
            case "oscar 11" when o11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "oscar 12" when o12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("O12");
                break;
            case "oscar 12" when o12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "oscar 13" when o13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("O13");
                break;
            case "oscar 13" when o13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "oscar 14" when o14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("O14");
                break;
            case "oscar 14" when o14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "oscar 15" when o15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("O15");
                break;
            case "oscar 15" when o15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "oscar 16" when o16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("O16");
                break;
            case "oscar 16" when o16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "oscar 17" when o17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("O17");
                break;
            case "oscar 17" when o17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "oscar 18" when o18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("O18");
                break;
            case "oscar 18" when o18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "oscar 19" when o19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("O19");
                break;
            case "oscar 19" when o19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "oscar 20" when o20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("O20");
                break;
            case "oscar 20" when o20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP
            case "papa 1" when p1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("P1");
                break;
            case "papa 1" when p1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "papa 2" when p2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("P2");
                break;
            case "papa 2" when p2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "papa 3" when p3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("P3");
                break;
            case "papa 3" when p3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "papa 4" when p4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("P4");
                break;
            case "papa 4" when p4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "papa 5" when p5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("P5");
                break;
            case "papa 5" when p5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "papa 6" when p6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("P6");
                break;
            case "papa 6" when p6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "papa 7" when p7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("P7");
                break;
            case "papa 7" when p7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "papa 8" when p8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("P8");
                break;
            case "papa 8" when p8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "papa 9" when p9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("P9");
                break;
            case "papa 9" when p9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "papa 10" when p10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("P10");
                break;
            case "papa 10" when p10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "papa 11" when p11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("P11");
                break;
            case "papa 11" when p11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "papa 12" when p12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("P12");
                break;
            case "papa 12" when p12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "papa 13" when p13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("P13");
                break;
            case "papa 13" when p13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "papa 14" when p14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("P14");
                break;
            case "papa 14" when p14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "papa 15" when p15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("P15");
                break;
            case "papa 15" when p15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "papa 16" when p16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("P16");
                break;
            case "papa 16" when p16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "papa 17" when p17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("P17");
                break;
            case "papa 17" when p17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "papa 18" when p18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("P18");
                break;
            case "papa 18" when p18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "papa 19" when p19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("P19");
                break;
            case "papa 19" when p19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "papa 20" when p20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("P20");
                break;
            case "papa 20" when p20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //QQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQ
            case "quebec 1" when q1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Q1");
                break;
            case "quebec 1" when q1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "quebec 2" when q2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Q2");
                break;
            case "quebec 2" when q2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "quebec 3" when q3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Q3");
                break;
            case "quebec 3" when q3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "quebec 4" when q4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Q4");
                break;
            case "quebec 4" when q4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "quebec 5" when q5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Q5");
                break;
            case "quebec 5" when q5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "quebec 6" when q6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Q6");
                break;
            case "quebec 6" when q6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "quebec 7" when q7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Q7");
                break;
            case "quebec 7" when q7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "quebec 8" when q8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Q8");
                break;
            case "quebec 8" when q8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "quebec 9" when q9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Q9");
                break;
            case "quebec 9" when q9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "quebec 10" when q10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Q10");
                break;
            case "quebec 10" when q10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "quebec 11" when q11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Q11");
                break;
            case "quebec 11" when q11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "quebec 12" when q12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Q12");
                break;
            case "quebec 12" when q12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "quebec 13" when q13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Q13");
                break;
            case "quebec 13" when q13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "quebec 14" when q14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Q14");
                break;
            case "quebec 14" when q14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "quebec 15" when q15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Q15");
                break;
            case "quebec 15" when q15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "quebec 16" when q16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Q16");
                break;
            case "quebec 16" when q16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "quebec 17" when q17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Q17");
                break;
            case "quebec 17" when q17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "quebec 18" when q18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Q18");
                break;
            case "quebec 18" when q18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "quebec 19" when q19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Q19");
                break;
            case "quebec 19" when q19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "quebec 20" when q20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Q20");
                break;
            case "quebec 20" when q20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR
            case "romeo 1" when r1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("R1");
                break;
            case "romeo 1" when r1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "romeo 2" when r2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("R2");
                break;
            case "romeo 2" when r2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "romeo 3" when r3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("R3");
                break;
            case "romeo 3" when r3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "romeo 4" when r4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("R4");
                break;
            case "romeo 4" when r4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "romeo 5" when r5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("R5");
                break;
            case "romeo 5" when r5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "romeo 6" when r6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("R6");
                break;
            case "romeo 6" when r6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "romeo 7" when r7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("R7");
                break;
            case "romeo 7" when r7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "romeo 8" when r8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("R8");
                break;
            case "romeo 8" when r8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "romeo 9" when r9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("R9");
                break;
            case "romeo 9" when r9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "romeo 10" when r10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("R10");
                break;
            case "romeo 10" when r10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "romeo 11" when r11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("R11");
                break;
            case "romeo 11" when r11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "romeo 12" when r12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("R12");
                break;
            case "romeo 12" when r12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "romeo 13" when r13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("R13");
                break;
            case "romeo 13" when r13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "romeo 14" when r14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("R14");
                break;
            case "romeo 14" when r14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "romeo 15" when r15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("R15");
                break;
            case "romeo 15" when r15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "romeo 16" when r16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("R16");
                break;
            case "romeo 16" when r16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "romeo 17" when r17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("R17");
                break;
            case "romeo 17" when r17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "romeo 18" when r18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("R18");
                break;
            case "romeo 18" when r18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "romeo 19" when r19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("R19");
                break;
            case "romeo 19" when r19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "romeo 20" when r20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("R20");
                break;
            case "romeo 20" when r20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS
            case "sierra 1" when s1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("S1");
                break;
            case "sierra 1" when s1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "sierra 2" when s2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("S2");
                break;
            case "sierra 2" when s2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "sierra 3" when s3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("S3");
                break;
            case "sierra 3" when s3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "sierra 4" when s4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("S4");
                break;
            case "sierra 4" when s4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "sierra 5" when s5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("S5");
                break;
            case "sierra 5" when s5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "sierra 6" when s6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("S6");
                break;
            case "sierra 6" when s6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "sierra 7" when s7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("S7");
                break;
            case "sierra 7" when s7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "sierra 8" when s8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("S8");
                break;
            case "sierra 8" when s8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "sierra 9" when s9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("S9");
                break;
            case "sierra 9" when s9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "sierra 10" when s10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("S10");
                break;
            case "sierra 10" when s10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "sierra 11" when s11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("S11");
                break;
            case "sierra 11" when s11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "sierra 12" when s12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("S12");
                break;
            case "sierra 12" when s12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "sierra 13" when s13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("S13");
                break;
            case "sierra 13" when s13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "sierra 14" when s14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("S14");
                break;
            case "sierra 14" when s14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "sierra 15" when s15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("S15");
                break;
            case "sierra 15" when s15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "sierra 16" when s16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("S16");
                break;
            case "sierra 16" when s16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "sierra 17" when s17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("S17");
                break;
            case "sierra 17" when s17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "sierra 18" when s18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("S18");
                break;
            case "sierra 18" when s18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "sierra 19" when s19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("S19");
                break;
            case "sierra 19" when s19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "sierra 20" when s20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("S20");
                break;
            case "sierra 20" when s20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
            case "tango 1" when t1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("T1");
                break;
            case "tango 1" when t1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "tango 2" when t2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("T2");
                break;
            case "tango 2" when t2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "tango 3" when t3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("T3");
                break;
            case "tango 3" when t3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "tango 4" when t4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("T4");
                break;
            case "tango 4" when t4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "tango 5" when t5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("T5");
                break;
            case "tango 5" when t5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "tango 6" when t6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("T6");
                break;
            case "tango 6" when t6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "tango 7" when t7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("T7");
                break;
            case "tango 7" when t7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "tango 8" when t8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("T8");
                break;
            case "tango 8" when t8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "tango 9" when t9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("T9");
                break;
            case "tango 9" when t9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "tango 10" when t10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("T10");
                break;
            case "tango 10" when t10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "tango 11" when t11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("T11");
                break;
            case "tango 11" when t11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "tango 12" when t12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("T12");
                break;
            case "tango 12" when t12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "tango 13" when t13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("T13");
                break;
            case "tango 13" when t13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "tango 14" when t14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("T14");
                break;
            case "tango 14" when t14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "tango 15" when t15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("T15");
                break;
            case "tango 15" when t15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "tango 16" when t16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("T16");
                break;
            case "tango 16" when t16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "tango 17" when t17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("T17");
                break;
            case "tango 17" when t17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "tango 18" when t18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("T18");
                break;
            case "tango 18" when t18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "tango 19" when t19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("T19");
                break;
            case "tango 19" when t19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "tango 20" when t20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("T20");
                break;
            case "tango 20" when t20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU
            case "uniform 1" when u1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("U1");
                break;
            case "uniform 1" when u1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "uniform 2" when u2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("U2");
                break;
            case "uniform 2" when u2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "uniform 3" when u3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("U3");
                break;
            case "uniform 3" when u3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "uniform 4" when u4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("U4");
                break;
            case "uniform 4" when u4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "uniform 5" when u5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("U5");
                break;
            case "uniform 5" when u5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "uniform 6" when u6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("U6");
                break;
            case "uniform 6" when u6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "uniform 7" when u7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("U7");
                break;
            case "uniform 7" when u7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "uniform 8" when u8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("U8");
                break;
            case "uniform 8" when u8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "uniform 9" when u9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("U9");
                break;
            case "uniform 9" when u9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "uniform 10" when u10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("U10");
                break;
            case "uniform 10" when u10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "uniform 11" when u11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("U11");
                break;
            case "uniform 11" when u11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "uniform 12" when u12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("U12");
                break;
            case "uniform 12" when u12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "uniform 13" when u13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("U13");
                break;
            case "uniform 13" when u13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "uniform 14" when u14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("U14");
                break;
            case "uniform 14" when u14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "uniform 15" when u15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("U15");
                break;
            case "uniform 15" when u15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "uniform 16" when u16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("U16");
                break;
            case "uniform 16" when u16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "uniform 17" when u17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("U17");
                break;
            case "uniform 17" when u17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "uniform 18" when u18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("U18");
                break;
            case "uniform 18" when u18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "uniform 19" when u19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("U19");
                break;
            case "uniform 19" when u19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "uniform 20" when u20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("U20");
                break;
            case "uniform 20" when u20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV
            case "victor 1" when v1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("V1");
                break;
            case "victor 1" when v1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "victor 2" when v2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("V2");
                break;
            case "victor 2" when v2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "victor 3" when v3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("V3");
                break;
            case "victor 3" when v3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "victor 4" when v4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("V4");
                break;
            case "victor 4" when v4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "victor 5" when v5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("V5");
                break;
            case "victor 5" when v5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "victor 6" when v6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("V6");
                break;
            case "victor 6" when v6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "victor 7" when v7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("V7");
                break;
            case "victor 7" when v7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "victor 8" when v8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("V8");
                break;
            case "victor 8" when v8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "victor 9" when v9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("V9");
                break;
            case "victor 9" when v9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "victor 10" when v10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("V10");
                break;
            case "victor 10" when v10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "victor 11" when v11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("V11");
                break;
            case "victor 11" when v11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "victor 12" when v12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("V12");
                break;
            case "victor 12" when v12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "victor 13" when v13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("V13");
                break;
            case "victor 13" when v13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "victor 14" when v14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("V14");
                break;
            case "victor 14" when v14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "victor 15" when v15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("V15");
                break;
            case "victor 15" when v15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "victor 16" when v16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("V16");
                break;
            case "victor 16" when v16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "victor 17" when v17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("V17");
                break;
            case "victor 17" when v17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "victor 18" when v18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("V18");
                break;
            case "victor 18" when v18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "victor 19" when v19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("V19");
                break;
            case "victor 19" when v19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "victor 20" when v20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("V20");
                break;
            case "victor 20" when v20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW
            case "whiskey 1" when w1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("W1");
                break;
            case "whiskey 1" when w1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "whiskey 2" when w2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("W2");
                break;
            case "whiskey 2" when w2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "whiskey 3" when w3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("W3");
                break;
            case "whiskey 3" when w3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "whiskey 4" when w4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("W4");
                break;
            case "whiskey 4" when w4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "whiskey 5" when w5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("W5");
                break;
            case "whiskey 5" when w5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "whiskey 6" when w6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("W6");
                break;
            case "whiskey 6" when w6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "whiskey 7" when w7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("W7");
                break;
            case "whiskey 7" when w7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "whiskey 8" when w8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("W8");
                break;
            case "whiskey 8" when w8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "whiskey 9" when w9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("W9");
                break;
            case "whiskey 9" when w9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "whiskey 10" when w10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("W10");
                break;
            case "whiskey 10" when w10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "whiskey 11" when w11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("W11");
                break;
            case "whiskey 11" when w11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "whiskey 12" when w12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("W12");
                break;
            case "whiskey 12" when w12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "whiskey 13" when w13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("W13");
                break;
            case "whiskey 13" when w13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "whiskey 14" when w14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("W14");
                break;
            case "whiskey 14" when w14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "whiskey 15" when w15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("W15");
                break;
            case "whiskey 15" when w15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "whiskey 16" when w16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("W16");
                break;
            case "whiskey 16" when w16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "whiskey 17" when w17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("W17");
                break;
            case "whiskey 17" when w17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "whiskey 18" when w18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("W18");
                break;
            case "whiskey 18" when w18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "whiskey 19" when w19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("W19");
                break;
            case "whiskey 19" when w19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "whiskey 20" when w20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("W20");
                break;
            case "whiskey 20" when w20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            case "x-ray 1" when x1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("X1");
                break;
            case "x-ray 1" when x1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "x-ray 2" when x2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("X2");
                break;
            case "x-ray 2" when x2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "x-ray 3" when x3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("X3");
                break;
            case "x-ray 3" when x3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "x-ray 4" when x4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("X4");
                break;
            case "x-ray 4" when x4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "x-ray 5" when x5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("X5");
                break;
            case "x-ray 5" when x5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "x-ray 6" when x6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("X6");
                break;
            case "x-ray 6" when x6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "x-ray 7" when x7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("X7");
                break;
            case "x-ray 7" when x7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "x-ray 8" when x8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("X8");
                break;
            case "x-ray 8" when x8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "x-ray 9" when x9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("X9");
                break;
            case "x-ray 9" when x9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "x-ray 10" when x10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("X10");
                break;
            case "x-ray 10" when x10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "x-ray 11" when x11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("X11");
                break;
            case "x-ray 11" when x11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "x-ray 12" when x12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("X12");
                break;
            case "x-ray 12" when x12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "x-ray 13" when x13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("X13");
                break;
            case "x-ray 13" when x13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "x-ray 14" when x14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("X14");
                break;
            case "x-ray 14" when x14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "x-ray 15" when x15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("X15");
                break;
            case "x-ray 15" when x15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "x-ray 16" when x16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("X16");
                break;
            case "x-ray 16" when x16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "x-ray 17" when x17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("X17");
                break;
            case "x-ray 17" when x17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "x-ray 18" when x18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("X18");
                break;
            case "x-ray 18" when x18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "x-ray 19" when x19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("X19");
                break;
            case "x-ray 19" when x19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "x-ray 20" when x20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("X20");
                break;
            case "x-ray 20" when x20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY
            case "yankee 1" when y1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Y1");
                break;
            case "yankee 1" when y1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "yankee 2" when y2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Y2");
                break;
            case "yankee 2" when y2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "yankee 3" when y3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Y3");
                break;
            case "yankee 3" when y3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "yankee 4" when y4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Y4");
                break;
            case "yankee 4" when y4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "yankee 5" when y5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Y5");
                break;
            case "yankee 5" when y5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "yankee 6" when y6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Y6");
                break;
            case "yankee 6" when y6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "yankee 7" when y7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Y7");
                break;
            case "yankee 7" when y7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "yankee 8" when y8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Y8");
                break;
            case "yankee 8" when y8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "yankee 9" when y9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Y9");
                break;
            case "yankee 9" when y9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "yankee 10" when y10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Y10");
                break;
            case "yankee 10" when y10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "yankee 11" when y11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Y11");
                break;
            case "yankee 11" when y11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "yankee 12" when y12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Y12");
                break;
            case "yankee 12" when y12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "yankee 13" when y13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Y13");
                break;
            case "yankee 13" when y13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "yankee 14" when y14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Y14");
                break;
            case "yankee 14" when y14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "yankee 15" when y15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Y15");
                break;
            case "yankee 15" when y15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "yankee 16" when y16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Y16");
                break;
            case "yankee 16" when y16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "yankee 17" when y17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Y17");
                break;
            case "yankee 17" when y17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "yankee 18" when y18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Y18");
                break;
            case "yankee 18" when y18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "yankee 19" when y19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Y19");
                break;
            case "yankee 19" when y19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "yankee 20" when y20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Y20");
                break;
            case "yankee 20" when y20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            //ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ
            case "zulu 1" when z1Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Z1");
                break;
            case "zulu 1" when z1Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "zulu 2" when z2Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Z2");
                break;
            case "zulu 2" when z2Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "zulu 3" when z3Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Z3");
                break;
            case "zulu 3" when z3Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "zulu 4" when z4Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Z4");
                break;
            case "zulu 4" when z4Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "zulu 5" when z5Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Z5");
                break;
            case "zulu 5" when z5Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "zulu 6" when z6Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Z6");
                break;
            case "zulu 6" when z6Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "zulu 7" when z7Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Z7");
                break;
            case "zulu 7" when z7Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "zulu 8" when z8Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Z8");
                break;
            case "zulu 8" when z8Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "zulu 9" when z9Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Z9");
                break;
            case "zulu 9" when z9Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "zulu 10" when z10Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Z10");
                break;
            case "zulu 10" when z10Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "zulu 11" when z11Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Z11");
                break;
            case "zulu 11" when z11Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "zulu 12" when z12Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Z12");
                break;
            case "zulu 12" when z12Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "zulu 13" when z13Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Z13");
                break;
            case "zulu 13" when z13Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "zulu 14" when z14Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Z14");
                break;
            case "zulu 14" when z14Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "zulu 15" when z15Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Z15");
                break;
            case "zulu 15" when z15Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "zulu 16" when z16Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Z16");
                break;
            case "zulu 16" when z16Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "zulu 17" when z17Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Z17");
                break;
            case "zulu 17" when z17Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "zulu 18" when z18Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Z18");
                break;
            case "zulu 18" when z18Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "zulu 19" when z19Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Z19");
                break;
            case "zulu 19" when z19Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
            case "zulu 20" when z20Bombable == true:
                PlayBombSound(Random.Range(1, 11));
                PlayHitMessage(Random.Range(1, 16));
                HitNumAdd();
                DetermineMarkerLocationWhenHit("Z20");
                break;
            case "zulu 20" when z20Bombable == false:
                PlayBombSound(Random.Range(1, 11));
                PlayMissedMessage(Random.Range(1, 24));
                MissNumAdd();
                break;
        }
    }
    //*/

    private void HitNumAdd()
    {
        todayFriendly.GetComponent<TextMeshProUGUI>().text = (int.Parse(todayFriendly.GetComponent<TextMeshProUGUI>().text) + Random.Range(0, 2)).ToString("00000");
        todayEnemy.GetComponent<TextMeshProUGUI>().text = (int.Parse(todayEnemy.GetComponent<TextMeshProUGUI>().text) + Random.Range(1, 10)).ToString("00000");
        todayCivilian.GetComponent<TextMeshProUGUI>().text = (int.Parse(todayCivilian.GetComponent<TextMeshProUGUI>().text) + Random.Range(0, 10)).ToString("00000");
    }

    private void MissNumAdd()
    {
        todayFriendly.GetComponent<TextMeshProUGUI>().text = (int.Parse(todayFriendly.GetComponent<TextMeshProUGUI>().text) + Random.Range(0, 20)).ToString("00000");
        todayEnemy.GetComponent<TextMeshProUGUI>().text = (int.Parse(todayEnemy.GetComponent<TextMeshProUGUI>().text) + Random.Range(0, 20)).ToString("00000");
        todayCivilian.GetComponent<TextMeshProUGUI>().text = (int.Parse(todayCivilian.GetComponent<TextMeshProUGUI>().text) + Random.Range(0, 20)).ToString("00000");
    }

    private void PlayBombSound(int soundChoice)
    {
        switch (soundChoice)
        {
            case 1:
                bombHit1.PlayDelayed(0); break;
            case 2:
                bombHit2.PlayDelayed(0); break;
            case 3:
                bombHit3.PlayDelayed(0); break;
            case 4:
                bombHit4.PlayDelayed(0); break;
            case 5:
                bombHit5.PlayDelayed(0); break;
            case 6:
                bombHit6.PlayDelayed(0); break;
            case 7:
                bombHit7.PlayDelayed(0); break;
            case 8:
                bombHit8.PlayDelayed(0); break;
            case 9:
                bombHit9.PlayDelayed(0); break;
            case 10:
                bombHit10.PlayDelayed(0); break;
        }
    }

    private void PlayMissedMessage(int missedChoice)
    {
        switch (missedChoice)
        {
            case 1:
                missVoice1.PlayDelayed(1.0f); break;
            case 2:
                missVoice2.PlayDelayed(1.0f); break;
            case 3:
                missVoice3.PlayDelayed(1.0f); break;
            case 4:
                missVoice4.PlayDelayed(1.0f); break;
            case 5:
                missVoice5.PlayDelayed(1.0f); break;
            case 6:
                missVoice6.PlayDelayed(1.0f); break;
            case 7:
                missVoice7.PlayDelayed(1.0f); break;
            case 8:
                missVoice8.PlayDelayed(1.0f); break;
            case 9:
                missVoice9.PlayDelayed(1.0f); break;
            case 10:
                missVoice10.PlayDelayed(1.0f); break;
            case 11:
                missVoice11.PlayDelayed(1.0f); break;
            case 12:
                missVoice12.PlayDelayed(1.0f); break;
            case 13:
                missVoice13.PlayDelayed(1.0f); break;
            case 14:
                missVoice14.PlayDelayed(1.0f); break;
            case 15:
                missVoice15.PlayDelayed(1.0f); break;
            case 16:
                missVoice16.PlayDelayed(1.0f); break;
            case 17:
                missVoice17.PlayDelayed(1.0f); break;
            case 18:
                missVoice18.PlayDelayed(1.0f); break;
            case 19:
                missVoice19.PlayDelayed(1.0f); break;
            case 20:
                missVoice20.PlayDelayed(1.0f); break;
            case 21:
                missVoice21.PlayDelayed(1.0f); break;
            case 22:
                missVoice22.PlayDelayed(1.0f); break;
            case 23:
                missVoice23.PlayDelayed(1.0f); break;
        }
    }

    private void PlayHitMessage(int yesChoice)
    {
        switch (yesChoice)
        {
            case 1:
                yesVoice1.PlayDelayed(1.0f); break;
            case 2:
                yesVoice2.PlayDelayed(1.0f); break;
            case 3:
                yesVoice3.PlayDelayed(1.0f); break;
            case 4:
                yesVoice4.PlayDelayed(1.0f); break;
            case 5:
                yesVoice5.PlayDelayed(1.0f); break;
            case 6:
                yesVoice6.PlayDelayed(1.0f); break;
            case 7:
                yesVoice7.PlayDelayed(1.0f); break;
            case 8:
                yesVoice8.PlayDelayed(1.0f); break;
            case 9:
                yesVoice9.PlayDelayed(1.0f); break;
            case 10:
                yesVoice10.PlayDelayed(1.0f); break;
            case 11:
                yesVoice11.PlayDelayed(1.0f); break;
            case 12:
                yesVoice12.PlayDelayed(1.0f); break;
            case 13:
                yesVoice13.PlayDelayed(1.0f); break;
            case 14:
                yesVoice14.PlayDelayed(1.0f); break;
            case 15:
                yesVoice15.PlayDelayed(1.0f); break;
        }
    }
    private void DetermineMarkerLocationWhenHit(string coordinateName)
    {
        for (int z = 0; z < 12; z++)
        {
            if (GameObject.Find(coordinateName).GetComponent<UICollider>().enteredMarks[z].CompareTag("Mark"))
            {
                for (int i = 1; i <= 12; i++)
                {
                    if (GameObject.Find(coordinateName).GetComponent<UICollider>().enteredMarks[z] == GameObject.Find("Mark" + i))
                    {
                        GameObject.Find("Mark" + i).SetActive(false);
                        StartCoroutine(Marks(i, UnityEngine.Random.Range(2.0f, 20.0f)));
                        GameObject.Find(coordinateName).GetComponent<UICollider>().enteredMarks[z] = GameObject.Find(coordinateName);
                        //break;
                    }
                }
            }
        }        
    }
    private IEnumerator Marks(int markNum, float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        switch (markNum)
        {
            case 1:
                mark1.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width/-2.1f, confinesRect.rect.width/2.1f), Random.Range(confinesRect.rect.height/-2.1f, confinesRect.rect.height/2.1f), 0); 
                mark1.SetActive(true);
                break;
            case 2:
                mark2.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width/-2.1f, confinesRect.rect.width/2.1f), Random.Range(confinesRect.rect.height/-2.1f, confinesRect.rect.height/2.1f), 0); 
                mark2.SetActive(true);
                break;
            case 3:
                mark3.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width/-2.1f, confinesRect.rect.width/2.1f), Random.Range(confinesRect.rect.height/-2.1f, confinesRect.rect.height/2.1f), 0); 
                mark3.SetActive(true);
                break;
            case 4:
                mark4.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width/-2.1f, confinesRect.rect.width/2.1f), Random.Range(confinesRect.rect.height/-2.1f, confinesRect.rect.height/2.1f), 0); 
                mark4.SetActive(true);
                break;
            case 5:
                mark5.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width/-2.1f, confinesRect.rect.width/2.1f), Random.Range(confinesRect.rect.height/-2.1f, confinesRect.rect.height/2.1f), 0); 
                mark5.SetActive(true);
                break;
            case 6:
                mark6.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width/-2.1f, confinesRect.rect.width/2.1f), Random.Range(confinesRect.rect.height/-2.1f, confinesRect.rect.height/2.1f), 0); 
                mark6.SetActive(true);
                break;
            case 7:
                mark7.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width/-2.1f, confinesRect.rect.width/2.1f), Random.Range(confinesRect.rect.height/-2.1f, confinesRect.rect.height/2.1f), 0); 
                mark7.SetActive(true);
                break;
            case 8:
                mark8.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width/-2.1f, confinesRect.rect.width/2.1f), Random.Range(confinesRect.rect.height/-2.1f, confinesRect.rect.height/2.1f), 0); 
                mark8.SetActive(true);
                break;
            case 9:
                mark9.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width/-2.1f, confinesRect.rect.width/2.1f), Random.Range(confinesRect.rect.height/-2.1f, confinesRect.rect.height/2.1f), 0); 
                mark9.SetActive(true);
                break;
            case 10:
                mark10.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width/-2.1f, confinesRect.rect.width/2.1f), Random.Range(confinesRect.rect.height/-2.1f, confinesRect.rect.height/2.1f), 0); 
                mark10.SetActive(true);
                break;
            case 11:
                mark11.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width/-2.1f, confinesRect.rect.width/2.1f), Random.Range(confinesRect.rect.height/-2.1f, confinesRect.rect.height/2.1f), 0); 
                mark11.SetActive(true);
                break;
            case 12:
                mark12.transform.localPosition = new Vector3(Random.Range(confinesRect.rect.width/-2.1f, confinesRect.rect.width/2.1f), Random.Range(confinesRect.rect.height/-2.1f, confinesRect.rect.height/2.1f), 0); 
                mark12.SetActive(true);
                break;
        }
    }
    
    
}
