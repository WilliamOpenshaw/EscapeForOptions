using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICollider : MonoBehaviour
{
    RectTransform rekt;
    BoxCollider2D coordinateCollider;
    public listener coordinates;

    public GameObject[] enteredMarks;

    public string objectName;

    void Start()
    {
        enteredMarks = new GameObject[12];
        for (int z = 0; z < 12; z++)
        {
            enteredMarks[z] = gameObject;
        }
    }
    void OnEnable()
    {
        rekt = gameObject.GetComponent<RectTransform>();
        coordinateCollider = gameObject.GetComponent<BoxCollider2D>();
        coordinateCollider.size = new Vector3(rekt.rect.width, rekt.rect.height, 0);
        objectName = gameObject.name;
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("Mark"))
        {
            for (int z = 0; z <= 12; z++)
            { 
                if(enteredMarks[z] = gameObject)
                {
                    enteredMarks[z] = col.gameObject;
                    break;
                }
            }            
            switch (objectName)
            {
                case "A1":

                    coordinates.a1Bombable = true;
                    break;

                case "A2":

                    coordinates.a2Bombable = true;
                    break;

                case "A3":

                    coordinates.a3Bombable = true;
                    break;

                case "A4":

                    coordinates.a4Bombable = true;
                    break;

                case "A5":

                    coordinates.a5Bombable = true;
                    break;

                case "A6":

                    coordinates.a6Bombable = true;
                    break;

                case "A7":

                    coordinates.a7Bombable = true;
                    break;

                case "A8":

                    coordinates.a8Bombable = true;
                    break;

                case "A9":

                    coordinates.a9Bombable = true;
                    break;

                case "A10":

                    coordinates.a10Bombable = true;
                    break;

                case "A11":

                    coordinates.a11Bombable = true;
                    break;

                case "A12":

                    coordinates.a12Bombable = true;
                    break;

                case "A13":

                    coordinates.a13Bombable = true;
                    break;

                case "A14":

                    coordinates.a14Bombable = true;
                    break;

                case "A15":

                    coordinates.a15Bombable = true;
                    break;

                case "A16":

                    coordinates.a16Bombable = true;
                    break;

                case "A17":

                    coordinates.a17Bombable = true;
                    break;

                case "A18":

                    coordinates.a18Bombable = true;
                    break;

                case "A19":

                    coordinates.a19Bombable = true;
                    break;

                case "A20":

                    coordinates.a20Bombable = true;
                    break;

                case "B1":

                    coordinates.b1Bombable = true;
                    break;

                case "B2":

                    coordinates.b2Bombable = true;
                    break;

                case "B3":

                    coordinates.b3Bombable = true;
                    break;

                case "B4":

                    coordinates.b4Bombable = true;
                    break;

                case "B5":

                    coordinates.b5Bombable = true;
                    break;


                case "B6":

                    coordinates.b6Bombable = true;
                    break;

                case "B7":

                    coordinates.b7Bombable = true;
                    break;

                case "B8":

                    coordinates.b8Bombable = true;
                    break;

                case "B9":

                    coordinates.b9Bombable = true;
                    break;

                case "B10":

                    coordinates.b10Bombable = true;
                    break;

                case "B11":

                    coordinates.b11Bombable = true;
                    break;

                case "B12":

                    coordinates.b12Bombable = true;
                    break;

                case "B13":

                    coordinates.b13Bombable = true;
                    break;

                case "B14":

                    coordinates.b14Bombable = true;
                    break;

                case "B15":

                    coordinates.b15Bombable = true;
                    break;

                case "B16":

                    coordinates.b16Bombable = true;
                    break;

                case "B17":

                    coordinates.b17Bombable = true;
                    break;

                case "B18":

                    coordinates.b18Bombable = true;
                    break;

                case "B19":

                    coordinates.b19Bombable = true;
                    break;

                case "B20":

                    coordinates.b20Bombable = true;
                    break;

                case "C1":

                    coordinates.c1Bombable = true;
                    break;

                case "C2":

                    coordinates.c2Bombable = true;
                    break;

                case "C3":

                    coordinates.c3Bombable = true;
                    break;

                case "C4":

                    coordinates.c4Bombable = true;
                    break;

                case "C5":

                    coordinates.c5Bombable = true;
                    break;


                case "C6":

                    coordinates.c6Bombable = true;
                    break;

                case "C7":

                    coordinates.c7Bombable = true;
                    break;

                case "C8":

                    coordinates.c8Bombable = true;
                    break;

                case "C9":

                    coordinates.c9Bombable = true;
                    break;

                case "C10":

                    coordinates.c10Bombable = true;
                    break;

                case "C11":

                    coordinates.c11Bombable = true;
                    break;

                case "C12":

                    coordinates.c12Bombable = true;
                    break;

                case "C13":

                    coordinates.c13Bombable = true;
                    break;

                case "C14":

                    coordinates.c14Bombable = true;
                    break;

                case "C15":

                    coordinates.c15Bombable = true;
                    break;

                case "C16":

                    coordinates.c16Bombable = true;
                    break;

                case "C17":

                    coordinates.c17Bombable = true;
                    break;

                case "C18":

                    coordinates.c18Bombable = true;
                    break;

                case "C19":

                    coordinates.c19Bombable = true;
                    break;

                case "C20":

                    coordinates.c20Bombable = true;
                    break;

                case "D1":

                    coordinates.d1Bombable = true;
                    break;

                case "D2":

                    coordinates.d2Bombable = true;
                    break;

                case "D3":

                    coordinates.d3Bombable = true;
                    break;

                case "D4":

                    coordinates.d4Bombable = true;
                    break;

                case "D5":

                    coordinates.d5Bombable = true;
                    break;

                case "D6":

                    coordinates.d6Bombable = true;
                    break;

                case "D7":

                    coordinates.d7Bombable = true;
                    break;

                case "D8":

                    coordinates.d8Bombable = true;
                    break;

                case "D9":

                    coordinates.d9Bombable = true;
                    break;

                case "D10":

                    coordinates.d10Bombable = true;
                    break;

                case "D11":

                    coordinates.d11Bombable = true;
                    break;

                case "D12":

                    coordinates.d12Bombable = true;
                    break;

                case "D13":

                    coordinates.d13Bombable = true;
                    break;

                case "D14":

                    coordinates.d14Bombable = true;
                    break;

                case "D15":

                    coordinates.d15Bombable = true;
                    break;

                case "D16":

                    coordinates.d16Bombable = true;
                    break;

                case "D17":

                    coordinates.d17Bombable = true;
                    break;

                case "D18":

                    coordinates.d18Bombable = true;
                    break;

                case "D19":

                    coordinates.d19Bombable = true;
                    break;

                case "D20":

                    coordinates.d20Bombable = true;
                    break;

                case "E1":

                    coordinates.e1Bombable = true;
                    break;

                case "E2":

                    coordinates.e2Bombable = true;
                    break;

                case "E3":

                    coordinates.e3Bombable = true;
                    break;

                case "E4":

                    coordinates.e4Bombable = true;
                    break;

                case "E5":

                    coordinates.e5Bombable = true;
                    break;


                case "E6":

                    coordinates.e6Bombable = true;
                    break;

                case "E7":

                    coordinates.e7Bombable = true;
                    break;

                case "E8":

                    coordinates.e8Bombable = true;
                    break;

                case "E9":

                    coordinates.e9Bombable = true;
                    break;

                case "E10":

                    coordinates.e10Bombable = true;
                    break;

                case "E11":

                    coordinates.e11Bombable = true;
                    break;

                case "E12":

                    coordinates.e12Bombable = true;
                    break;

                case "E13":

                    coordinates.e13Bombable = true;
                    break;

                case "E14":

                    coordinates.e14Bombable = true;
                    break;

                case "E15":

                    coordinates.e15Bombable = true;
                    break;

                case "E16":

                    coordinates.e16Bombable = true;
                    break;

                case "E17":

                    coordinates.e17Bombable = true;
                    break;

                case "E18":

                    coordinates.e18Bombable = true;
                    break;

                case "E19":

                    coordinates.e19Bombable = true;
                    break;

                case "E20":

                    coordinates.e20Bombable = true;
                    break;

                case "F1":

                    coordinates.f1Bombable = true;
                    break;

                case "F2":

                    coordinates.f2Bombable = true;
                    break;

                case "F3":

                    coordinates.f3Bombable = true;
                    break;

                case "F4":

                    coordinates.f4Bombable = true;
                    break;

                case "F5":

                    coordinates.f5Bombable = true;
                    break;


                case "F6":

                    coordinates.f6Bombable = true;
                    break;

                case "F7":

                    coordinates.f7Bombable = true;
                    break;

                case "F8":

                    coordinates.f8Bombable = true;
                    break;

                case "F9":

                    coordinates.f9Bombable = true;
                    break;

                case "F10":

                    coordinates.f10Bombable = true;
                    break;

                case "F11":

                    coordinates.f11Bombable = true;
                    break;

                case "F12":

                    coordinates.f12Bombable = true;
                    break;

                case "F13":

                    coordinates.f13Bombable = true;
                    break;

                case "F14":

                    coordinates.f14Bombable = true;
                    break;

                case "F15":

                    coordinates.f15Bombable = true;
                    break;

                case "F16":

                    coordinates.f16Bombable = true;
                    break;

                case "F17":

                    coordinates.f17Bombable = true;
                    break;

                case "F18":

                    coordinates.f18Bombable = true;
                    break;

                case "F19":

                    coordinates.f19Bombable = true;
                    break;

                case "F20":

                    coordinates.f20Bombable = true;
                    break;

                case "G1":

                    coordinates.g1Bombable = true;
                    break;

                case "G2":

                    coordinates.g2Bombable = true;
                    break;

                case "G3":

                    coordinates.g3Bombable = true;
                    break;

                case "G4":

                    coordinates.g4Bombable = true;
                    break;

                case "G5":

                    coordinates.g5Bombable = true;
                    break;


                case "G6":

                    coordinates.g6Bombable = true;
                    break;

                case "G7":

                    coordinates.g7Bombable = true;
                    break;

                case "G8":

                    coordinates.g8Bombable = true;
                    break;

                case "G9":

                    coordinates.g9Bombable = true;
                    break;

                case "G10":

                    coordinates.g10Bombable = true;
                    break;

                case "G11":

                    coordinates.g11Bombable = true;
                    break;

                case "G12":

                    coordinates.g12Bombable = true;
                    break;

                case "G13":

                    coordinates.g13Bombable = true;
                    break;

                case "G14":

                    coordinates.g14Bombable = true;
                    break;

                case "G15":

                    coordinates.g15Bombable = true;
                    break;

                case "G16":

                    coordinates.g16Bombable = true;
                    break;

                case "G17":

                    coordinates.g17Bombable = true;
                    break;

                case "G18":

                    coordinates.g18Bombable = true;
                    break;

                case "G19":

                    coordinates.g19Bombable = true;
                    break;

                case "G20":

                    coordinates.g20Bombable = true;
                    break;

                case "H1":

                    coordinates.h1Bombable = true;
                    break;

                case "H2":

                    coordinates.h2Bombable = true;
                    break;

                case "H3":

                    coordinates.h3Bombable = true;
                    break;

                case "H4":

                    coordinates.h4Bombable = true;
                    break;

                case "H5":

                    coordinates.h5Bombable = true;
                    break;


                case "H6":

                    coordinates.h6Bombable = true;
                    break;

                case "H7":

                    coordinates.h7Bombable = true;
                    break;

                case "H8":

                    coordinates.h8Bombable = true;
                    break;

                case "H9":

                    coordinates.h9Bombable = true;
                    break;

                case "H10":

                    coordinates.h10Bombable = true;
                    break;

                case "H11":

                    coordinates.h11Bombable = true;
                    break;

                case "H12":

                    coordinates.h12Bombable = true;
                    break;

                case "H13":

                    coordinates.h13Bombable = true;
                    break;

                case "H14":

                    coordinates.h14Bombable = true;
                    break;

                case "H15":

                    coordinates.h15Bombable = true;
                    break;

                case "H16":

                    coordinates.h16Bombable = true;
                    break;

                case "H17":

                    coordinates.h17Bombable = true;
                    break;

                case "H18":

                    coordinates.h18Bombable = true;
                    break;

                case "H19":

                    coordinates.h19Bombable = true;
                    break;

                case "H20":

                    coordinates.h20Bombable = true;
                    break;

                case "I1":

                    coordinates.i1Bombable = true;
                    break;

                case "I2":

                    coordinates.i2Bombable = true;
                    break;

                case "I3":

                    coordinates.i3Bombable = true;
                    break;

                case "I4":

                    coordinates.i4Bombable = true;
                    break;

                case "I5":

                    coordinates.i5Bombable = true;
                    break;


                case "I6":

                    coordinates.i6Bombable = true;
                    break;

                case "I7":

                    coordinates.i7Bombable = true;
                    break;

                case "I8":

                    coordinates.i8Bombable = true;
                    break;

                case "I9":

                    coordinates.i9Bombable = true;
                    break;

                case "I10":

                    coordinates.i10Bombable = true;
                    break;

                case "I11":

                    coordinates.i11Bombable = true;
                    break;

                case "I12":

                    coordinates.i12Bombable = true;
                    break;

                case "I13":

                    coordinates.i13Bombable = true;
                    break;

                case "I14":

                    coordinates.i14Bombable = true;
                    break;

                case "I15":

                    coordinates.i15Bombable = true;
                    break;

                case "I16":

                    coordinates.i16Bombable = true;
                    break;

                case "I17":

                    coordinates.i17Bombable = true;
                    break;

                case "I18":

                    coordinates.i18Bombable = true;
                    break;

                case "I19":

                    coordinates.i19Bombable = true;
                    break;

                case "I20":

                    coordinates.i20Bombable = true;
                    break;

                case "J1":

                    coordinates.j1Bombable = true;
                    break;

                case "J2":

                    coordinates.j2Bombable = true;
                    break;

                case "J3":

                    coordinates.j3Bombable = true;
                    break;

                case "J4":

                    coordinates.j4Bombable = true;
                    break;

                case "J5":

                    coordinates.j5Bombable = true;
                    break;


                case "J6":

                    coordinates.j6Bombable = true;
                    break;

                case "J7":

                    coordinates.j7Bombable = true;
                    break;

                case "J8":

                    coordinates.j8Bombable = true;
                    break;

                case "J9":

                    coordinates.j9Bombable = true;
                    break;

                case "J10":

                    coordinates.j10Bombable = true;
                    break;

                case "J11":

                    coordinates.j11Bombable = true;
                    break;

                case "J12":

                    coordinates.j12Bombable = true;
                    break;

                case "J13":

                    coordinates.j13Bombable = true;
                    break;

                case "J14":

                    coordinates.j14Bombable = true;
                    break;

                case "J15":

                    coordinates.j15Bombable = true;
                    break;

                case "J16":

                    coordinates.j16Bombable = true;
                    break;

                case "J17":

                    coordinates.j17Bombable = true;
                    break;

                case "J18":

                    coordinates.j18Bombable = true;
                    break;

                case "J19":

                    coordinates.j19Bombable = true;
                    break;

                case "J20":

                    coordinates.j20Bombable = true;
                    break;

                case "K1":

                    coordinates.k1Bombable = true;
                    break;

                case "K2":

                    coordinates.k2Bombable = true;
                    break;

                case "K3":

                    coordinates.k3Bombable = true;
                    break;

                case "K4":

                    coordinates.k4Bombable = true;
                    break;

                case "K5":

                    coordinates.k5Bombable = true;
                    break;


                case "K6":

                    coordinates.k6Bombable = true;
                    break;

                case "K7":

                    coordinates.k7Bombable = true;
                    break;

                case "K8":

                    coordinates.k8Bombable = true;
                    break;

                case "K9":

                    coordinates.k9Bombable = true;
                    break;

                case "K10":

                    coordinates.k10Bombable = true;
                    break;

                case "K11":

                    coordinates.k11Bombable = true;
                    break;

                case "K12":

                    coordinates.k12Bombable = true;
                    break;

                case "K13":

                    coordinates.k13Bombable = true;
                    break;

                case "K14":

                    coordinates.k14Bombable = true;
                    break;

                case "K15":

                    coordinates.k15Bombable = true;
                    break;

                case "K16":

                    coordinates.k16Bombable = true;
                    break;

                case "K17":

                    coordinates.k17Bombable = true;
                    break;

                case "K18":

                    coordinates.k18Bombable = true;
                    break;

                case "K19":

                    coordinates.k19Bombable = true;
                    break;

                case "K20":

                    coordinates.k20Bombable = true;
                    break;

                case "L1":

                    coordinates.l1Bombable = true;
                    break;

                case "L2":

                    coordinates.l2Bombable = true;
                    break;

                case "L3":

                    coordinates.l3Bombable = true;
                    break;

                case "L4":

                    coordinates.l4Bombable = true;
                    break;

                case "L5":

                    coordinates.l5Bombable = true;
                    break;


                case "L6":

                    coordinates.l6Bombable = true;
                    break;

                case "L7":

                    coordinates.l7Bombable = true;
                    break;

                case "L8":

                    coordinates.l8Bombable = true;
                    break;

                case "L9":

                    coordinates.l9Bombable = true;
                    break;

                case "L10":

                    coordinates.l10Bombable = true;
                    break;

                case "L11":

                    coordinates.l11Bombable = true;
                    break;

                case "L12":

                    coordinates.l12Bombable = true;
                    break;

                case "L13":

                    coordinates.l13Bombable = true;
                    break;

                case "L14":

                    coordinates.l14Bombable = true;
                    break;

                case "L15":

                    coordinates.l15Bombable = true;
                    break;

                case "L16":

                    coordinates.l16Bombable = true;
                    break;

                case "L17":

                    coordinates.l17Bombable = true;
                    break;

                case "L18":

                    coordinates.l18Bombable = true;
                    break;

                case "L19":

                    coordinates.l19Bombable = true;
                    break;

                case "L20":

                    coordinates.l20Bombable = true;
                    break;

                case "M1":

                    coordinates.m1Bombable = true;
                    break;

                case "M2":

                    coordinates.m2Bombable = true;
                    break;

                case "M3":

                    coordinates.m3Bombable = true;
                    break;

                case "M4":

                    coordinates.m4Bombable = true;
                    break;

                case "M5":

                    coordinates.m5Bombable = true;
                    break;


                case "M6":

                    coordinates.m6Bombable = true;
                    break;

                case "M7":

                    coordinates.m7Bombable = true;
                    break;

                case "M8":

                    coordinates.m8Bombable = true;
                    break;

                case "M9":

                    coordinates.m9Bombable = true;
                    break;

                case "M10":

                    coordinates.m10Bombable = true;
                    break;

                case "M11":

                    coordinates.m11Bombable = true;
                    break;

                case "M12":

                    coordinates.m12Bombable = true;
                    break;

                case "M13":

                    coordinates.m13Bombable = true;
                    break;

                case "M14":

                    coordinates.m14Bombable = true;
                    break;

                case "M15":

                    coordinates.m15Bombable = true;
                    break;

                case "M16":

                    coordinates.m16Bombable = true;
                    break;

                case "M17":

                    coordinates.m17Bombable = true;
                    break;

                case "M18":

                    coordinates.m18Bombable = true;
                    break;

                case "M19":

                    coordinates.m19Bombable = true;
                    break;

                case "M20":

                    coordinates.m20Bombable = true;
                    break;

                case "N1":

                    coordinates.n1Bombable = true;
                    break;

                case "N2":

                    coordinates.n2Bombable = true;
                    break;

                case "N3":

                    coordinates.n3Bombable = true;
                    break;

                case "N4":

                    coordinates.n4Bombable = true;
                    break;

                case "N5":

                    coordinates.n5Bombable = true;
                    break;


                case "N6":

                    coordinates.n6Bombable = true;
                    break;

                case "N7":

                    coordinates.n7Bombable = true;
                    break;

                case "N8":

                    coordinates.n8Bombable = true;
                    break;

                case "N9":

                    coordinates.n9Bombable = true;
                    break;

                case "N10":

                    coordinates.n10Bombable = true;
                    break;

                case "N11":

                    coordinates.n11Bombable = true;
                    break;

                case "N12":

                    coordinates.n12Bombable = true;
                    break;

                case "N13":

                    coordinates.n13Bombable = true;
                    break;

                case "N14":

                    coordinates.n14Bombable = true;
                    break;

                case "N15":

                    coordinates.n15Bombable = true;
                    break;

                case "N16":

                    coordinates.n16Bombable = true;
                    break;

                case "N17":

                    coordinates.n17Bombable = true;
                    break;

                case "N18":

                    coordinates.n18Bombable = true;
                    break;

                case "N19":

                    coordinates.n19Bombable = true;
                    break;

                case "N20":

                    coordinates.n20Bombable = true;
                    break;

                case "O1":

                    coordinates.o1Bombable = true;
                    break;

                case "O2":

                    coordinates.o2Bombable = true;
                    break;

                case "O3":

                    coordinates.o3Bombable = true;
                    break;

                case "O4":

                    coordinates.o4Bombable = true;
                    break;

                case "O5":

                    coordinates.o5Bombable = true;
                    break;


                case "O6":

                    coordinates.o6Bombable = true;
                    break;

                case "O7":

                    coordinates.o7Bombable = true;
                    break;

                case "O8":

                    coordinates.o8Bombable = true;
                    break;

                case "O9":

                    coordinates.o9Bombable = true;
                    break;

                case "O10":

                    coordinates.o10Bombable = true;
                    break;

                case "O11":

                    coordinates.o11Bombable = true;
                    break;

                case "O12":

                    coordinates.o12Bombable = true;
                    break;

                case "O13":

                    coordinates.o13Bombable = true;
                    break;

                case "O14":

                    coordinates.o14Bombable = true;
                    break;

                case "O15":

                    coordinates.o15Bombable = true;
                    break;

                case "O16":

                    coordinates.o16Bombable = true;
                    break;

                case "O17":

                    coordinates.o17Bombable = true;
                    break;

                case "O18":

                    coordinates.o18Bombable = true;
                    break;

                case "O19":

                    coordinates.o19Bombable = true;
                    break;

                case "O20":

                    coordinates.o20Bombable = true;
                    break;

                case "P1":

                    coordinates.p1Bombable = true;
                    break;

                case "P2":

                    coordinates.p2Bombable = true;
                    break;

                case "P3":

                    coordinates.p3Bombable = true;
                    break;

                case "P4":

                    coordinates.p4Bombable = true;
                    break;

                case "P5":

                    coordinates.p5Bombable = true;
                    break;


                case "P6":

                    coordinates.p6Bombable = true;
                    break;

                case "P7":

                    coordinates.p7Bombable = true;
                    break;

                case "P8":

                    coordinates.p8Bombable = true;
                    break;

                case "P9":

                    coordinates.p9Bombable = true;
                    break;

                case "P10":

                    coordinates.p10Bombable = true;
                    break;

                case "P11":

                    coordinates.p11Bombable = true;
                    break;

                case "P12":

                    coordinates.p12Bombable = true;
                    break;

                case "P13":

                    coordinates.p13Bombable = true;
                    break;

                case "P14":

                    coordinates.p14Bombable = true;
                    break;

                case "P15":

                    coordinates.p15Bombable = true;
                    break;

                case "P16":

                    coordinates.p16Bombable = true;
                    break;

                case "P17":

                    coordinates.p17Bombable = true;
                    break;

                case "P18":

                    coordinates.p18Bombable = true;
                    break;

                case "P19":

                    coordinates.p19Bombable = true;
                    break;

                case "P20":

                    coordinates.p20Bombable = true;
                    break;

                case "Q1":

                    coordinates.q1Bombable = true;
                    break;

                case "Q2":

                    coordinates.q2Bombable = true;
                    break;

                case "Q3":

                    coordinates.q3Bombable = true;
                    break;

                case "Q4":

                    coordinates.q4Bombable = true;
                    break;

                case "Q5":

                    coordinates.q5Bombable = true;
                    break;


                case "Q6":

                    coordinates.q6Bombable = true;
                    break;

                case "Q7":

                    coordinates.q7Bombable = true;
                    break;

                case "Q8":

                    coordinates.q8Bombable = true;
                    break;

                case "Q9":

                    coordinates.q9Bombable = true;
                    break;

                case "Q10":

                    coordinates.q10Bombable = true;
                    break;

                case "Q11":

                    coordinates.q11Bombable = true;
                    break;

                case "Q12":

                    coordinates.q12Bombable = true;
                    break;

                case "Q13":

                    coordinates.q13Bombable = true;
                    break;

                case "Q14":

                    coordinates.q14Bombable = true;
                    break;

                case "Q15":

                    coordinates.q15Bombable = true;
                    break;

                case "Q16":

                    coordinates.q16Bombable = true;
                    break;

                case "Q17":

                    coordinates.q17Bombable = true;
                    break;

                case "Q18":

                    coordinates.q18Bombable = true;
                    break;

                case "Q19":

                    coordinates.q19Bombable = true;
                    break;

                case "Q20":

                    coordinates.q20Bombable = true;
                    break;

                case "R1":

                    coordinates.r1Bombable = true;
                    break;

                case "R2":

                    coordinates.r2Bombable = true;
                    break;

                case "R3":

                    coordinates.r3Bombable = true;
                    break;

                case "R4":

                    coordinates.r4Bombable = true;
                    break;

                case "R5":

                    coordinates.r5Bombable = true;
                    break;


                case "R6":

                    coordinates.r6Bombable = true;
                    break;

                case "R7":

                    coordinates.r7Bombable = true;
                    break;

                case "R8":

                    coordinates.r8Bombable = true;
                    break;

                case "R9":

                    coordinates.r9Bombable = true;
                    break;

                case "R10":

                    coordinates.r10Bombable = true;
                    break;

                case "R11":

                    coordinates.r11Bombable = true;
                    break;

                case "R12":

                    coordinates.r12Bombable = true;
                    break;

                case "R13":

                    coordinates.r13Bombable = true;
                    break;

                case "R14":

                    coordinates.r14Bombable = true;
                    break;

                case "R15":

                    coordinates.r15Bombable = true;
                    break;

                case "R16":

                    coordinates.r16Bombable = true;
                    break;

                case "R17":

                    coordinates.r17Bombable = true;
                    break;

                case "R18":

                    coordinates.r18Bombable = true;
                    break;

                case "R19":

                    coordinates.r19Bombable = true;
                    break;

                case "R20":

                    coordinates.r20Bombable = true;
                    break;


                case "S1":

                    coordinates.s1Bombable = true;
                    break;

                case "S2":

                    coordinates.s2Bombable = true;
                    break;

                case "S3":

                    coordinates.s3Bombable = true;
                    break;

                case "S4":

                    coordinates.s4Bombable = true;
                    break;

                case "S5":

                    coordinates.s5Bombable = true;
                    break;


                case "S6":

                    coordinates.s6Bombable = true;
                    break;

                case "S7":

                    coordinates.s7Bombable = true;
                    break;

                case "S8":

                    coordinates.s8Bombable = true;
                    break;

                case "S9":

                    coordinates.s9Bombable = true;
                    break;

                case "S10":

                    coordinates.s10Bombable = true;
                    break;

                case "S11":

                    coordinates.s11Bombable = true;
                    break;

                case "S12":

                    coordinates.s12Bombable = true;
                    break;

                case "S13":

                    coordinates.s13Bombable = true;
                    break;

                case "S14":

                    coordinates.s14Bombable = true;
                    break;

                case "S15":

                    coordinates.s15Bombable = true;
                    break;

                case "S16":

                    coordinates.s16Bombable = true;
                    break;

                case "S17":

                    coordinates.s17Bombable = true;
                    break;

                case "S18":

                    coordinates.s18Bombable = true;
                    break;

                case "S19":

                    coordinates.s19Bombable = true;
                    break;

                case "S20":

                    coordinates.s20Bombable = true;
                    break;
                case "T1":

                    coordinates.t1Bombable = true;
                    break;

                case "T2":

                    coordinates.t2Bombable = true;
                    break;

                case "T3":

                    coordinates.t3Bombable = true;
                    break;

                case "T4":

                    coordinates.t4Bombable = true;
                    break;

                case "T5":

                    coordinates.t5Bombable = true;
                    break;


                case "T6":

                    coordinates.t6Bombable = true;
                    break;

                case "T7":

                    coordinates.t7Bombable = true;
                    break;

                case "T8":

                    coordinates.t8Bombable = true;
                    break;

                case "T9":

                    coordinates.t9Bombable = true;
                    break;

                case "T10":

                    coordinates.t10Bombable = true;
                    break;

                case "T11":

                    coordinates.t11Bombable = true;
                    break;

                case "T12":

                    coordinates.t12Bombable = true;
                    break;

                case "T13":

                    coordinates.t13Bombable = true;
                    break;

                case "T14":

                    coordinates.t14Bombable = true;
                    break;

                case "T15":

                    coordinates.t15Bombable = true;
                    break;

                case "T16":

                    coordinates.t16Bombable = true;
                    break;

                case "T17":

                    coordinates.t17Bombable = true;
                    break;

                case "T18":

                    coordinates.t18Bombable = true;
                    break;

                case "T19":

                    coordinates.t19Bombable = true;
                    break;

                case "T20":

                    coordinates.t20Bombable = true;
                    break;
                case "U1":

                    coordinates.u1Bombable = true;
                    break;

                case "U2":

                    coordinates.u2Bombable = true;
                    break;

                case "U3":

                    coordinates.u3Bombable = true;
                    break;

                case "U4":

                    coordinates.u4Bombable = true;
                    break;

                case "U5":

                    coordinates.u5Bombable = true;
                    break;


                case "U6":

                    coordinates.u6Bombable = true;
                    break;

                case "U7":

                    coordinates.u7Bombable = true;
                    break;

                case "U8":

                    coordinates.u8Bombable = true;
                    break;

                case "U9":

                    coordinates.u9Bombable = true;
                    break;

                case "U10":

                    coordinates.u10Bombable = true;
                    break;

                case "U11":

                    coordinates.u11Bombable = true;
                    break;

                case "U12":

                    coordinates.u12Bombable = true;
                    break;

                case "U13":

                    coordinates.u13Bombable = true;
                    break;

                case "U14":

                    coordinates.u14Bombable = true;
                    break;

                case "U15":

                    coordinates.u15Bombable = true;
                    break;

                case "U16":

                    coordinates.u16Bombable = true;
                    break;

                case "U17":

                    coordinates.u17Bombable = true;
                    break;

                case "U18":

                    coordinates.u18Bombable = true;
                    break;

                case "U19":

                    coordinates.u19Bombable = true;
                    break;

                case "U20":

                    coordinates.u20Bombable = true;
                    break;
                case "V1":

                    coordinates.v1Bombable = true;
                    break;

                case "V2":

                    coordinates.v2Bombable = true;
                    break;

                case "V3":

                    coordinates.v3Bombable = true;
                    break;

                case "V4":

                    coordinates.v4Bombable = true;
                    break;

                case "V5":

                    coordinates.v5Bombable = true;
                    break;


                case "V6":

                    coordinates.v6Bombable = true;
                    break;

                case "V7":

                    coordinates.v7Bombable = true;
                    break;

                case "V8":

                    coordinates.v8Bombable = true;
                    break;

                case "V9":

                    coordinates.v9Bombable = true;
                    break;

                case "V10":

                    coordinates.v10Bombable = true;
                    break;

                case "V11":

                    coordinates.v11Bombable = true;
                    break;

                case "V12":

                    coordinates.v12Bombable = true;
                    break;

                case "V13":

                    coordinates.v13Bombable = true;
                    break;

                case "V14":

                    coordinates.v14Bombable = true;
                    break;

                case "V15":

                    coordinates.v15Bombable = true;
                    break;

                case "V16":

                    coordinates.v16Bombable = true;
                    break;

                case "V17":

                    coordinates.v17Bombable = true;
                    break;

                case "V18":

                    coordinates.v18Bombable = true;
                    break;

                case "V19":

                    coordinates.v19Bombable = true;
                    break;

                case "V20":

                    coordinates.v20Bombable = true;
                    break;
                case "W1":

                    coordinates.w1Bombable = true;
                    break;

                case "W2":

                    coordinates.w2Bombable = true;
                    break;

                case "W3":

                    coordinates.w3Bombable = true;
                    break;

                case "W4":

                    coordinates.w4Bombable = true;
                    break;

                case "W5":

                    coordinates.w5Bombable = true;
                    break;


                case "W6":

                    coordinates.w6Bombable = true;
                    break;

                case "W7":

                    coordinates.w7Bombable = true;
                    break;

                case "W8":

                    coordinates.w8Bombable = true;
                    break;

                case "W9":

                    coordinates.w9Bombable = true;
                    break;

                case "W10":

                    coordinates.w10Bombable = true;
                    break;

                case "W11":

                    coordinates.w11Bombable = true;
                    break;

                case "W12":

                    coordinates.w12Bombable = true;
                    break;

                case "W13":

                    coordinates.w13Bombable = true;
                    break;

                case "W14":

                    coordinates.w14Bombable = true;
                    break;

                case "W15":

                    coordinates.w15Bombable = true;
                    break;

                case "W16":

                    coordinates.w16Bombable = true;
                    break;

                case "W17":

                    coordinates.w17Bombable = true;
                    break;

                case "W18":

                    coordinates.w18Bombable = true;
                    break;

                case "W19":

                    coordinates.w19Bombable = true;
                    break;

                case "W20":

                    coordinates.w20Bombable = true;
                    break;
                case "X1":

                    coordinates.x1Bombable = true;
                    break;

                case "X2":

                    coordinates.x2Bombable = true;
                    break;

                case "X3":

                    coordinates.x3Bombable = true;
                    break;

                case "X4":

                    coordinates.x4Bombable = true;
                    break;

                case "X5":

                    coordinates.x5Bombable = true;
                    break;


                case "X6":

                    coordinates.x6Bombable = true;
                    break;

                case "X7":

                    coordinates.x7Bombable = true;
                    break;

                case "X8":

                    coordinates.x8Bombable = true;
                    break;

                case "X9":

                    coordinates.x9Bombable = true;
                    break;

                case "X10":

                    coordinates.x10Bombable = true;
                    break;

                case "X11":

                    coordinates.x11Bombable = true;
                    break;

                case "X12":

                    coordinates.x12Bombable = true;
                    break;

                case "X13":

                    coordinates.x13Bombable = true;
                    break;

                case "X14":

                    coordinates.x14Bombable = true;
                    break;

                case "X15":

                    coordinates.x15Bombable = true;
                    break;

                case "X16":

                    coordinates.x16Bombable = true;
                    break;

                case "X17":

                    coordinates.x17Bombable = true;
                    break;

                case "X18":

                    coordinates.x18Bombable = true;
                    break;

                case "X19":

                    coordinates.x19Bombable = true;
                    break;

                case "X20":

                    coordinates.x20Bombable = true;
                    break;
                case "Y1":

                    coordinates.y1Bombable = true;
                    break;

                case "Y2":

                    coordinates.y2Bombable = true;
                    break;

                case "Y3":

                    coordinates.y3Bombable = true;
                    break;

                case "Y4":

                    coordinates.y4Bombable = true;
                    break;

                case "Y5":

                    coordinates.y5Bombable = true;
                    break;


                case "Y6":

                    coordinates.y6Bombable = true;
                    break;

                case "Y7":

                    coordinates.y7Bombable = true;
                    break;

                case "Y8":

                    coordinates.y8Bombable = true;
                    break;

                case "Y9":

                    coordinates.y9Bombable = true;
                    break;

                case "Y10":

                    coordinates.y10Bombable = true;
                    break;

                case "Y11":

                    coordinates.y11Bombable = true;
                    break;

                case "Y12":

                    coordinates.y12Bombable = true;
                    break;

                case "Y13":

                    coordinates.y13Bombable = true;
                    break;

                case "Y14":

                    coordinates.y14Bombable = true;
                    break;

                case "Y15":

                    coordinates.y15Bombable = true;
                    break;

                case "Y16":

                    coordinates.y16Bombable = true;
                    break;

                case "Y17":

                    coordinates.y17Bombable = true;
                    break;

                case "Y18":

                    coordinates.y18Bombable = true;
                    break;

                case "Y19":

                    coordinates.y19Bombable = true;
                    break;

                case "Y20":

                    coordinates.y20Bombable = true;
                    break;
                case "Z1":

                    coordinates.z1Bombable = true;
                    break;

                case "Z2":

                    coordinates.z2Bombable = true;
                    break;

                case "Z3":

                    coordinates.z3Bombable = true;
                    break;

                case "Z4":

                    coordinates.z4Bombable = true;
                    break;

                case "Z5":

                    coordinates.z5Bombable = true;
                    break;


                case "Z6":

                    coordinates.z6Bombable = true;
                    break;

                case "Z7":

                    coordinates.z7Bombable = true;
                    break;

                case "Z8":

                    coordinates.z8Bombable = true;
                    break;

                case "Z9":

                    coordinates.z9Bombable = true;
                    break;

                case "Z10":

                    coordinates.z10Bombable = true;
                    break;

                case "Z11":

                    coordinates.z11Bombable = true;
                    break;

                case "Z12":

                    coordinates.z12Bombable = true;
                    break;

                case "Z13":

                    coordinates.z13Bombable = true;
                    break;

                case "Z14":

                    coordinates.z14Bombable = true;
                    break;

                case "Z15":

                    coordinates.z15Bombable = true;
                    break;

                case "Z16":

                    coordinates.z16Bombable = true;
                    break;

                case "Z17":

                    coordinates.z17Bombable = true;
                    break;

                case "Z18":

                    coordinates.z18Bombable = true;
                    break;

                case "Z19":

                    coordinates.z19Bombable = true;
                    break;

                case "Z20":

                    coordinates.z20Bombable = true;
                    break;
            }
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("Mark"))
        {
            switch (objectName)
            {
                case "A1":

                    coordinates.a1Bombable = false;
                    break;

                case "A2":

                    coordinates.a2Bombable = false;
                    break;

                case "A3":

                    coordinates.a3Bombable = false;
                    break;

                case "A4":

                    coordinates.a4Bombable = false;
                    break;

                case "A5":

                    coordinates.a5Bombable = false;
                    break;

                case "A6":

                    coordinates.a6Bombable = false;
                    break;

                case "A7":

                    coordinates.a7Bombable = false;
                    break;

                case "A8":

                    coordinates.a8Bombable = false;
                    break;

                case "A9":

                    coordinates.a9Bombable = false;
                    break;

                case "A10":

                    coordinates.a10Bombable = false;
                    break;

                case "A11":

                    coordinates.a11Bombable = false;
                    break;

                case "A12":

                    coordinates.a12Bombable = false;
                    break;

                case "A13":

                    coordinates.a13Bombable = false;
                    break;

                case "A14":

                    coordinates.a14Bombable = false;
                    break;

                case "A15":

                    coordinates.a15Bombable = false;
                    break;

                case "A16":

                    coordinates.a16Bombable = false;
                    break;

                case "A17":

                    coordinates.a17Bombable = false;
                    break;

                case "A18":

                    coordinates.a18Bombable = false;
                    break;

                case "A19":

                    coordinates.a19Bombable = false;
                    break;

                case "A20":

                    coordinates.a20Bombable = false;
                    break;

                case "B1":

                    coordinates.b1Bombable = false;
                    break;

                case "B2":

                    coordinates.b2Bombable = false;
                    break;

                case "B3":

                    coordinates.b3Bombable = false;
                    break;

                case "B4":

                    coordinates.b4Bombable = false;
                    break;

                case "B5":

                    coordinates.b5Bombable = false;
                    break;


                case "B6":

                    coordinates.b6Bombable = false;
                    break;

                case "B7":

                    coordinates.b7Bombable = false;
                    break;

                case "B8":

                    coordinates.b8Bombable = false;
                    break;

                case "B9":

                    coordinates.b9Bombable = false;
                    break;

                case "B10":

                    coordinates.b10Bombable = false;
                    break;

                case "B11":

                    coordinates.b11Bombable = false;
                    break;

                case "B12":

                    coordinates.b12Bombable = false;
                    break;

                case "B13":

                    coordinates.b13Bombable = false;
                    break;

                case "B14":

                    coordinates.b14Bombable = false;
                    break;

                case "B15":

                    coordinates.b15Bombable = false;
                    break;

                case "B16":

                    coordinates.b16Bombable = false;
                    break;

                case "B17":

                    coordinates.b17Bombable = false;
                    break;

                case "B18":

                    coordinates.b18Bombable = false;
                    break;

                case "B19":

                    coordinates.b19Bombable = false;
                    break;

                case "B20":

                    coordinates.b20Bombable = false;
                    break;

                case "C1":

                    coordinates.c1Bombable = false;
                    break;

                case "C2":

                    coordinates.c2Bombable = false;
                    break;

                case "C3":

                    coordinates.c3Bombable = false;
                    break;

                case "C4":

                    coordinates.c4Bombable = false;
                    break;

                case "C5":

                    coordinates.c5Bombable = false;
                    break;


                case "C6":

                    coordinates.c6Bombable = false;
                    break;

                case "C7":

                    coordinates.c7Bombable = false;
                    break;

                case "C8":

                    coordinates.c8Bombable = false;
                    break;

                case "C9":

                    coordinates.c9Bombable = false;
                    break;

                case "C10":

                    coordinates.c10Bombable = false;
                    break;

                case "C11":

                    coordinates.c11Bombable = false;
                    break;

                case "C12":

                    coordinates.c12Bombable = false;
                    break;

                case "C13":

                    coordinates.c13Bombable = false;
                    break;

                case "C14":

                    coordinates.c14Bombable = false;
                    break;

                case "C15":

                    coordinates.c15Bombable = false;
                    break;

                case "C16":

                    coordinates.c16Bombable = false;
                    break;

                case "C17":

                    coordinates.c17Bombable = false;
                    break;

                case "C18":

                    coordinates.c18Bombable = false;
                    break;

                case "C19":

                    coordinates.c19Bombable = false;
                    break;

                case "C20":

                    coordinates.c20Bombable = false;
                    break;

                case "D1":

                    coordinates.d1Bombable = false;
                    break;

                case "D2":

                    coordinates.d2Bombable = false;
                    break;

                case "D3":

                    coordinates.d3Bombable = false;
                    break;

                case "D4":

                    coordinates.d4Bombable = false;
                    break;

                case "D5":

                    coordinates.d5Bombable = false;
                    break;

                case "D6":

                    coordinates.d6Bombable = false;
                    break;

                case "D7":

                    coordinates.d7Bombable = false;
                    break;

                case "D8":

                    coordinates.d8Bombable = false;
                    break;

                case "D9":

                    coordinates.d9Bombable = false;
                    break;

                case "D10":

                    coordinates.d10Bombable = false;
                    break;

                case "D11":

                    coordinates.d11Bombable = false;
                    break;

                case "D12":

                    coordinates.d12Bombable = false;
                    break;

                case "D13":

                    coordinates.d13Bombable = false;
                    break;

                case "D14":

                    coordinates.d14Bombable = false;
                    break;

                case "D15":

                    coordinates.d15Bombable = false;
                    break;

                case "D16":

                    coordinates.d16Bombable = false;
                    break;

                case "D17":

                    coordinates.d17Bombable = false;
                    break;

                case "D18":

                    coordinates.d18Bombable = false;
                    break;

                case "D19":

                    coordinates.d19Bombable = false;
                    break;

                case "D20":

                    coordinates.d20Bombable = false;
                    break;

                case "E1":

                    coordinates.e1Bombable = false;
                    break;

                case "E2":

                    coordinates.e2Bombable = false;
                    break;

                case "E3":

                    coordinates.e3Bombable = false;
                    break;

                case "E4":

                    coordinates.e4Bombable = false;
                    break;

                case "E5":

                    coordinates.e5Bombable = false;
                    break;


                case "E6":

                    coordinates.e6Bombable = false;
                    break;

                case "E7":

                    coordinates.e7Bombable = false;
                    break;

                case "E8":

                    coordinates.e8Bombable = false;
                    break;

                case "E9":

                    coordinates.e9Bombable = false;
                    break;

                case "E10":

                    coordinates.e10Bombable = false;
                    break;

                case "E11":

                    coordinates.e11Bombable = false;
                    break;

                case "E12":

                    coordinates.e12Bombable = false;
                    break;

                case "E13":

                    coordinates.e13Bombable = false;
                    break;

                case "E14":

                    coordinates.e14Bombable = false;
                    break;

                case "E15":

                    coordinates.e15Bombable = false;
                    break;

                case "E16":

                    coordinates.e16Bombable = false;
                    break;

                case "E17":

                    coordinates.e17Bombable = false;
                    break;

                case "E18":

                    coordinates.e18Bombable = false;
                    break;

                case "E19":

                    coordinates.e19Bombable = false;
                    break;

                case "E20":

                    coordinates.e20Bombable = false;
                    break;

                case "F1":

                    coordinates.f1Bombable = false;
                    break;

                case "F2":

                    coordinates.f2Bombable = false;
                    break;

                case "F3":

                    coordinates.f3Bombable = false;
                    break;

                case "F4":

                    coordinates.f4Bombable = false;
                    break;

                case "F5":

                    coordinates.f5Bombable = false;
                    break;


                case "F6":

                    coordinates.f6Bombable = false;
                    break;

                case "F7":

                    coordinates.f7Bombable = false;
                    break;

                case "F8":

                    coordinates.f8Bombable = false;
                    break;

                case "F9":

                    coordinates.f9Bombable = false;
                    break;

                case "F10":

                    coordinates.f10Bombable = false;
                    break;

                case "F11":

                    coordinates.f11Bombable = false;
                    break;

                case "F12":

                    coordinates.f12Bombable = false;
                    break;

                case "F13":

                    coordinates.f13Bombable = false;
                    break;

                case "F14":

                    coordinates.f14Bombable = false;
                    break;

                case "F15":

                    coordinates.f15Bombable = false;
                    break;

                case "F16":

                    coordinates.f16Bombable = false;
                    break;

                case "F17":

                    coordinates.f17Bombable = false;
                    break;

                case "F18":

                    coordinates.f18Bombable = false;
                    break;

                case "F19":

                    coordinates.f19Bombable = false;
                    break;

                case "F20":

                    coordinates.f20Bombable = false;
                    break;

                case "G1":

                    coordinates.g1Bombable = false;
                    break;

                case "G2":

                    coordinates.g2Bombable = false;
                    break;

                case "G3":

                    coordinates.g3Bombable = false;
                    break;

                case "G4":

                    coordinates.g4Bombable = false;
                    break;

                case "G5":

                    coordinates.g5Bombable = false;
                    break;


                case "G6":

                    coordinates.g6Bombable = false;
                    break;

                case "G7":

                    coordinates.g7Bombable = false;
                    break;

                case "G8":

                    coordinates.g8Bombable = false;
                    break;

                case "G9":

                    coordinates.g9Bombable = false;
                    break;

                case "G10":

                    coordinates.g10Bombable = false;
                    break;

                case "G11":

                    coordinates.g11Bombable = false;
                    break;

                case "G12":

                    coordinates.g12Bombable = false;
                    break;

                case "G13":

                    coordinates.g13Bombable = false;
                    break;

                case "G14":

                    coordinates.g14Bombable = false;
                    break;

                case "G15":

                    coordinates.g15Bombable = false;
                    break;

                case "G16":

                    coordinates.g16Bombable = false;
                    break;

                case "G17":

                    coordinates.g17Bombable = false;
                    break;

                case "G18":

                    coordinates.g18Bombable = false;
                    break;

                case "G19":

                    coordinates.g19Bombable = false;
                    break;

                case "G20":

                    coordinates.g20Bombable = false;
                    break;

                case "H1":

                    coordinates.h1Bombable = false;
                    break;

                case "H2":

                    coordinates.h2Bombable = false;
                    break;

                case "H3":

                    coordinates.h3Bombable = false;
                    break;

                case "H4":

                    coordinates.h4Bombable = false;
                    break;

                case "H5":

                    coordinates.h5Bombable = false;
                    break;


                case "H6":

                    coordinates.h6Bombable = false;
                    break;

                case "H7":

                    coordinates.h7Bombable = false;
                    break;

                case "H8":

                    coordinates.h8Bombable = false;
                    break;

                case "H9":

                    coordinates.h9Bombable = false;
                    break;

                case "H10":

                    coordinates.h10Bombable = false;
                    break;

                case "H11":

                    coordinates.h11Bombable = false;
                    break;

                case "H12":

                    coordinates.h12Bombable = false;
                    break;

                case "H13":

                    coordinates.h13Bombable = false;
                    break;

                case "H14":

                    coordinates.h14Bombable = false;
                    break;

                case "H15":

                    coordinates.h15Bombable = false;
                    break;

                case "H16":

                    coordinates.h16Bombable = false;
                    break;

                case "H17":

                    coordinates.h17Bombable = false;
                    break;

                case "H18":

                    coordinates.h18Bombable = false;
                    break;

                case "H19":

                    coordinates.h19Bombable = false;
                    break;

                case "H20":

                    coordinates.h20Bombable = false;
                    break;

                case "I1":

                    coordinates.i1Bombable = false;
                    break;

                case "I2":

                    coordinates.i2Bombable = false;
                    break;

                case "I3":

                    coordinates.i3Bombable = false;
                    break;

                case "I4":

                    coordinates.i4Bombable = false;
                    break;

                case "I5":

                    coordinates.i5Bombable = false;
                    break;


                case "I6":

                    coordinates.i6Bombable = false;
                    break;

                case "I7":

                    coordinates.i7Bombable = false;
                    break;

                case "I8":

                    coordinates.i8Bombable = false;
                    break;

                case "I9":

                    coordinates.i9Bombable = false;
                    break;

                case "I10":

                    coordinates.i10Bombable = false;
                    break;

                case "I11":

                    coordinates.i11Bombable = false;
                    break;

                case "I12":

                    coordinates.i12Bombable = false;
                    break;

                case "I13":

                    coordinates.i13Bombable = false;
                    break;

                case "I14":

                    coordinates.i14Bombable = false;
                    break;

                case "I15":

                    coordinates.i15Bombable = false;
                    break;

                case "I16":

                    coordinates.i16Bombable = false;
                    break;

                case "I17":

                    coordinates.i17Bombable = false;
                    break;

                case "I18":

                    coordinates.i18Bombable = false;
                    break;

                case "I19":

                    coordinates.i19Bombable = false;
                    break;

                case "I20":

                    coordinates.i20Bombable = false;
                    break;

                case "J1":

                    coordinates.j1Bombable = false;
                    break;

                case "J2":

                    coordinates.j2Bombable = false;
                    break;

                case "J3":

                    coordinates.j3Bombable = false;
                    break;

                case "J4":

                    coordinates.j4Bombable = false;
                    break;

                case "J5":

                    coordinates.j5Bombable = false;
                    break;


                case "J6":

                    coordinates.j6Bombable = false;
                    break;

                case "J7":

                    coordinates.j7Bombable = false;
                    break;

                case "J8":

                    coordinates.j8Bombable = false;
                    break;

                case "J9":

                    coordinates.j9Bombable = false;
                    break;

                case "J10":

                    coordinates.j10Bombable = false;
                    break;

                case "J11":

                    coordinates.j11Bombable = false;
                    break;

                case "J12":

                    coordinates.j12Bombable = false;
                    break;

                case "J13":

                    coordinates.j13Bombable = false;
                    break;

                case "J14":

                    coordinates.j14Bombable = false;
                    break;

                case "J15":

                    coordinates.j15Bombable = false;
                    break;

                case "J16":

                    coordinates.j16Bombable = false;
                    break;

                case "J17":

                    coordinates.j17Bombable = false;
                    break;

                case "J18":

                    coordinates.j18Bombable = false;
                    break;

                case "J19":

                    coordinates.j19Bombable = false;
                    break;

                case "J20":

                    coordinates.j20Bombable = false;
                    break;

                case "K1":

                    coordinates.k1Bombable = false;
                    break;

                case "K2":

                    coordinates.k2Bombable = false;
                    break;

                case "K3":

                    coordinates.k3Bombable = false;
                    break;

                case "K4":

                    coordinates.k4Bombable = false;
                    break;

                case "K5":

                    coordinates.k5Bombable = false;
                    break;


                case "K6":

                    coordinates.k6Bombable = false;
                    break;

                case "K7":

                    coordinates.k7Bombable = false;
                    break;

                case "K8":

                    coordinates.k8Bombable = false;
                    break;

                case "K9":

                    coordinates.k9Bombable = false;
                    break;

                case "K10":

                    coordinates.k10Bombable = false;
                    break;

                case "K11":

                    coordinates.k11Bombable = false;
                    break;

                case "K12":

                    coordinates.k12Bombable = false;
                    break;

                case "K13":

                    coordinates.k13Bombable = false;
                    break;

                case "K14":

                    coordinates.k14Bombable = false;
                    break;

                case "K15":

                    coordinates.k15Bombable = false;
                    break;

                case "K16":

                    coordinates.k16Bombable = false;
                    break;

                case "K17":

                    coordinates.k17Bombable = false;
                    break;

                case "K18":

                    coordinates.k18Bombable = false;
                    break;

                case "K19":

                    coordinates.k19Bombable = false;
                    break;

                case "K20":

                    coordinates.k20Bombable = false;
                    break;

                case "L1":

                    coordinates.l1Bombable = false;
                    break;

                case "L2":

                    coordinates.l2Bombable = false;
                    break;

                case "L3":

                    coordinates.l3Bombable = false;
                    break;

                case "L4":

                    coordinates.l4Bombable = false;
                    break;

                case "L5":

                    coordinates.l5Bombable = false;
                    break;


                case "L6":

                    coordinates.l6Bombable = false;
                    break;

                case "L7":

                    coordinates.l7Bombable = false;
                    break;

                case "L8":

                    coordinates.l8Bombable = false;
                    break;

                case "L9":

                    coordinates.l9Bombable = false;
                    break;

                case "L10":

                    coordinates.l10Bombable = false;
                    break;

                case "L11":

                    coordinates.l11Bombable = false;
                    break;

                case "L12":

                    coordinates.l12Bombable = false;
                    break;

                case "L13":

                    coordinates.l13Bombable = false;
                    break;

                case "L14":

                    coordinates.l14Bombable = false;
                    break;

                case "L15":

                    coordinates.l15Bombable = false;
                    break;

                case "L16":

                    coordinates.l16Bombable = false;
                    break;

                case "L17":

                    coordinates.l17Bombable = false;
                    break;

                case "L18":

                    coordinates.l18Bombable = false;
                    break;

                case "L19":

                    coordinates.l19Bombable = false;
                    break;

                case "L20":

                    coordinates.l20Bombable = false;
                    break;

                case "M1":

                    coordinates.m1Bombable = false;
                    break;

                case "M2":

                    coordinates.m2Bombable = false;
                    break;

                case "M3":

                    coordinates.m3Bombable = false;
                    break;

                case "M4":

                    coordinates.m4Bombable = false;
                    break;

                case "M5":

                    coordinates.m5Bombable = false;
                    break;


                case "M6":

                    coordinates.m6Bombable = false;
                    break;

                case "M7":

                    coordinates.m7Bombable = false;
                    break;

                case "M8":

                    coordinates.m8Bombable = false;
                    break;

                case "M9":

                    coordinates.m9Bombable = false;
                    break;

                case "M10":

                    coordinates.m10Bombable = false;
                    break;

                case "M11":

                    coordinates.m11Bombable = false;
                    break;

                case "M12":

                    coordinates.m12Bombable = false;
                    break;

                case "M13":

                    coordinates.m13Bombable = false;
                    break;

                case "M14":

                    coordinates.m14Bombable = false;
                    break;

                case "M15":

                    coordinates.m15Bombable = false;
                    break;

                case "M16":

                    coordinates.m16Bombable = false;
                    break;

                case "M17":

                    coordinates.m17Bombable = false;
                    break;

                case "M18":

                    coordinates.m18Bombable = false;
                    break;

                case "M19":

                    coordinates.m19Bombable = false;
                    break;

                case "M20":

                    coordinates.m20Bombable = false;
                    break;

                case "N1":

                    coordinates.n1Bombable = false;
                    break;

                case "N2":

                    coordinates.n2Bombable = false;
                    break;

                case "N3":

                    coordinates.n3Bombable = false;
                    break;

                case "N4":

                    coordinates.n4Bombable = false;
                    break;

                case "N5":

                    coordinates.n5Bombable = false;
                    break;


                case "N6":

                    coordinates.n6Bombable = false;
                    break;

                case "N7":

                    coordinates.n7Bombable = false;
                    break;

                case "N8":

                    coordinates.n8Bombable = false;
                    break;

                case "N9":

                    coordinates.n9Bombable = false;
                    break;

                case "N10":

                    coordinates.n10Bombable = false;
                    break;

                case "N11":

                    coordinates.n11Bombable = false;
                    break;

                case "N12":

                    coordinates.n12Bombable = false;
                    break;

                case "N13":

                    coordinates.n13Bombable = false;
                    break;

                case "N14":

                    coordinates.n14Bombable = false;
                    break;

                case "N15":

                    coordinates.n15Bombable = false;
                    break;

                case "N16":

                    coordinates.n16Bombable = false;
                    break;

                case "N17":

                    coordinates.n17Bombable = false;
                    break;

                case "N18":

                    coordinates.n18Bombable = false;
                    break;

                case "N19":

                    coordinates.n19Bombable = false;
                    break;

                case "N20":

                    coordinates.n20Bombable = false;
                    break;

                case "O1":

                    coordinates.o1Bombable = false;
                    break;

                case "O2":

                    coordinates.o2Bombable = false;
                    break;

                case "O3":

                    coordinates.o3Bombable = false;
                    break;

                case "O4":

                    coordinates.o4Bombable = false;
                    break;

                case "O5":

                    coordinates.o5Bombable = false;
                    break;


                case "O6":

                    coordinates.o6Bombable = false;
                    break;

                case "O7":

                    coordinates.o7Bombable = false;
                    break;

                case "O8":

                    coordinates.o8Bombable = false;
                    break;

                case "O9":

                    coordinates.o9Bombable = false;
                    break;

                case "O10":

                    coordinates.o10Bombable = false;
                    break;

                case "O11":

                    coordinates.o11Bombable = false;
                    break;

                case "O12":

                    coordinates.o12Bombable = false;
                    break;

                case "O13":

                    coordinates.o13Bombable = false;
                    break;

                case "O14":

                    coordinates.o14Bombable = false;
                    break;

                case "O15":

                    coordinates.o15Bombable = false;
                    break;

                case "O16":

                    coordinates.o16Bombable = false;
                    break;

                case "O17":

                    coordinates.o17Bombable = false;
                    break;

                case "O18":

                    coordinates.o18Bombable = false;
                    break;

                case "O19":

                    coordinates.o19Bombable = false;
                    break;

                case "O20":

                    coordinates.o20Bombable = false;
                    break;

                case "P1":

                    coordinates.p1Bombable = false;
                    break;

                case "P2":

                    coordinates.p2Bombable = false;
                    break;

                case "P3":

                    coordinates.p3Bombable = false;
                    break;

                case "P4":

                    coordinates.p4Bombable = false;
                    break;

                case "P5":

                    coordinates.p5Bombable = false;
                    break;


                case "P6":

                    coordinates.p6Bombable = false;
                    break;

                case "P7":

                    coordinates.p7Bombable = false;
                    break;

                case "P8":

                    coordinates.p8Bombable = false;
                    break;

                case "P9":

                    coordinates.p9Bombable = false;
                    break;

                case "P10":

                    coordinates.p10Bombable = false;
                    break;

                case "P11":

                    coordinates.p11Bombable = false;
                    break;

                case "P12":

                    coordinates.p12Bombable = false;
                    break;

                case "P13":

                    coordinates.p13Bombable = false;
                    break;

                case "P14":

                    coordinates.p14Bombable = false;
                    break;

                case "P15":

                    coordinates.p15Bombable = false;
                    break;

                case "P16":

                    coordinates.p16Bombable = false;
                    break;

                case "P17":

                    coordinates.p17Bombable = false;
                    break;

                case "P18":

                    coordinates.p18Bombable = false;
                    break;

                case "P19":

                    coordinates.p19Bombable = false;
                    break;

                case "P20":

                    coordinates.p20Bombable = false;
                    break;

                case "Q1":

                    coordinates.q1Bombable = false;
                    break;

                case "Q2":

                    coordinates.q2Bombable = false;
                    break;

                case "Q3":

                    coordinates.q3Bombable = false;
                    break;

                case "Q4":

                    coordinates.q4Bombable = false;
                    break;

                case "Q5":

                    coordinates.q5Bombable = false;
                    break;


                case "Q6":

                    coordinates.q6Bombable = false;
                    break;

                case "Q7":

                    coordinates.q7Bombable = false;
                    break;

                case "Q8":

                    coordinates.q8Bombable = false;
                    break;

                case "Q9":

                    coordinates.q9Bombable = false;
                    break;

                case "Q10":

                    coordinates.q10Bombable = false;
                    break;

                case "Q11":

                    coordinates.q11Bombable = false;
                    break;

                case "Q12":

                    coordinates.q12Bombable = false;
                    break;

                case "Q13":

                    coordinates.q13Bombable = false;
                    break;

                case "Q14":

                    coordinates.q14Bombable = false;
                    break;

                case "Q15":

                    coordinates.q15Bombable = false;
                    break;

                case "Q16":

                    coordinates.q16Bombable = false;
                    break;

                case "Q17":

                    coordinates.q17Bombable = false;
                    break;

                case "Q18":

                    coordinates.q18Bombable = false;
                    break;

                case "Q19":

                    coordinates.q19Bombable = false;
                    break;

                case "Q20":

                    coordinates.q20Bombable = false;
                    break;

                case "R1":

                    coordinates.r1Bombable = false;
                    break;

                case "R2":

                    coordinates.r2Bombable = false;
                    break;

                case "R3":

                    coordinates.r3Bombable = false;
                    break;

                case "R4":

                    coordinates.r4Bombable = false;
                    break;

                case "R5":

                    coordinates.r5Bombable = false;
                    break;


                case "R6":

                    coordinates.r6Bombable = false;
                    break;

                case "R7":

                    coordinates.r7Bombable = false;
                    break;

                case "R8":

                    coordinates.r8Bombable = false;
                    break;

                case "R9":

                    coordinates.r9Bombable = false;
                    break;

                case "R10":

                    coordinates.r10Bombable = false;
                    break;

                case "R11":

                    coordinates.r11Bombable = false;
                    break;

                case "R12":

                    coordinates.r12Bombable = false;
                    break;

                case "R13":

                    coordinates.r13Bombable = false;
                    break;

                case "R14":

                    coordinates.r14Bombable = false;
                    break;

                case "R15":

                    coordinates.r15Bombable = false;
                    break;

                case "R16":

                    coordinates.r16Bombable = false;
                    break;

                case "R17":

                    coordinates.r17Bombable = false;
                    break;

                case "R18":

                    coordinates.r18Bombable = false;
                    break;

                case "R19":

                    coordinates.r19Bombable = false;
                    break;

                case "R20":

                    coordinates.r20Bombable = false;
                    break;


                case "S1":

                    coordinates.s1Bombable = false;
                    break;

                case "S2":

                    coordinates.s2Bombable = false;
                    break;

                case "S3":

                    coordinates.s3Bombable = false;
                    break;

                case "S4":

                    coordinates.s4Bombable = false;
                    break;

                case "S5":

                    coordinates.s5Bombable = false;
                    break;


                case "S6":

                    coordinates.s6Bombable = false;
                    break;

                case "S7":

                    coordinates.s7Bombable = false;
                    break;

                case "S8":

                    coordinates.s8Bombable = false;
                    break;

                case "S9":

                    coordinates.s9Bombable = false;
                    break;

                case "S10":

                    coordinates.s10Bombable = false;
                    break;

                case "S11":

                    coordinates.s11Bombable = false;
                    break;

                case "S12":

                    coordinates.s12Bombable = false;
                    break;

                case "S13":

                    coordinates.s13Bombable = false;
                    break;

                case "S14":

                    coordinates.s14Bombable = false;
                    break;

                case "S15":

                    coordinates.s15Bombable = false;
                    break;

                case "S16":

                    coordinates.s16Bombable = false;
                    break;

                case "S17":

                    coordinates.s17Bombable = false;
                    break;

                case "S18":

                    coordinates.s18Bombable = false;
                    break;

                case "S19":

                    coordinates.s19Bombable = false;
                    break;

                case "S20":

                    coordinates.s20Bombable = false;
                    break;
                case "T1":

                    coordinates.t1Bombable = false;
                    break;

                case "T2":

                    coordinates.t2Bombable = false;
                    break;

                case "T3":

                    coordinates.t3Bombable = false;
                    break;

                case "T4":

                    coordinates.t4Bombable = false;
                    break;

                case "T5":

                    coordinates.t5Bombable = false;
                    break;


                case "T6":

                    coordinates.t6Bombable = false;
                    break;

                case "T7":

                    coordinates.t7Bombable = false;
                    break;

                case "T8":

                    coordinates.t8Bombable = false;
                    break;

                case "T9":

                    coordinates.t9Bombable = false;
                    break;

                case "T10":

                    coordinates.t10Bombable = false;
                    break;

                case "T11":

                    coordinates.t11Bombable = false;
                    break;

                case "T12":

                    coordinates.t12Bombable = false;
                    break;

                case "T13":

                    coordinates.t13Bombable = false;
                    break;

                case "T14":

                    coordinates.t14Bombable = false;
                    break;

                case "T15":

                    coordinates.t15Bombable = false;
                    break;

                case "T16":

                    coordinates.t16Bombable = false;
                    break;

                case "T17":

                    coordinates.t17Bombable = false;
                    break;

                case "T18":

                    coordinates.t18Bombable = false;
                    break;

                case "T19":

                    coordinates.t19Bombable = false;
                    break;

                case "T20":

                    coordinates.t20Bombable = false;
                    break;
                case "U1":

                    coordinates.u1Bombable = false;
                    break;

                case "U2":

                    coordinates.u2Bombable = false;
                    break;

                case "U3":

                    coordinates.u3Bombable = false;
                    break;

                case "U4":

                    coordinates.u4Bombable = false;
                    break;

                case "U5":

                    coordinates.u5Bombable = false;
                    break;


                case "U6":

                    coordinates.u6Bombable = false;
                    break;

                case "U7":

                    coordinates.u7Bombable = false;
                    break;

                case "U8":

                    coordinates.u8Bombable = false;
                    break;

                case "U9":

                    coordinates.u9Bombable = false;
                    break;

                case "U10":

                    coordinates.u10Bombable = false;
                    break;

                case "U11":

                    coordinates.u11Bombable = false;
                    break;

                case "U12":

                    coordinates.u12Bombable = false;
                    break;

                case "U13":

                    coordinates.u13Bombable = false;
                    break;

                case "U14":

                    coordinates.u14Bombable = false;
                    break;

                case "U15":

                    coordinates.u15Bombable = false;
                    break;

                case "U16":

                    coordinates.u16Bombable = false;
                    break;

                case "U17":

                    coordinates.u17Bombable = false;
                    break;

                case "U18":

                    coordinates.u18Bombable = false;
                    break;

                case "U19":

                    coordinates.u19Bombable = false;
                    break;

                case "U20":

                    coordinates.u20Bombable = false;
                    break;
                case "V1":

                    coordinates.v1Bombable = false;
                    break;

                case "V2":

                    coordinates.v2Bombable = false;
                    break;

                case "V3":

                    coordinates.v3Bombable = false;
                    break;

                case "V4":

                    coordinates.v4Bombable = false;
                    break;

                case "V5":

                    coordinates.v5Bombable = false;
                    break;


                case "V6":

                    coordinates.v6Bombable = false;
                    break;

                case "V7":

                    coordinates.v7Bombable = false;
                    break;

                case "V8":

                    coordinates.v8Bombable = false;
                    break;

                case "V9":

                    coordinates.v9Bombable = false;
                    break;

                case "V10":

                    coordinates.v10Bombable = false;
                    break;

                case "V11":

                    coordinates.v11Bombable = false;
                    break;

                case "V12":

                    coordinates.v12Bombable = false;
                    break;

                case "V13":

                    coordinates.v13Bombable = false;
                    break;

                case "V14":

                    coordinates.v14Bombable = false;
                    break;

                case "V15":

                    coordinates.v15Bombable = false;
                    break;

                case "V16":

                    coordinates.v16Bombable = false;
                    break;

                case "V17":

                    coordinates.v17Bombable = false;
                    break;

                case "V18":

                    coordinates.v18Bombable = false;
                    break;

                case "V19":

                    coordinates.v19Bombable = false;
                    break;

                case "V20":

                    coordinates.v20Bombable = false;
                    break;
                case "W1":

                    coordinates.w1Bombable = false;
                    break;

                case "W2":

                    coordinates.w2Bombable = false;
                    break;

                case "W3":

                    coordinates.w3Bombable = false;
                    break;

                case "W4":

                    coordinates.w4Bombable = false;
                    break;

                case "W5":

                    coordinates.w5Bombable = false;
                    break;


                case "W6":

                    coordinates.w6Bombable = false;
                    break;

                case "W7":

                    coordinates.w7Bombable = false;
                    break;

                case "W8":

                    coordinates.w8Bombable = false;
                    break;

                case "W9":

                    coordinates.w9Bombable = false;
                    break;

                case "W10":

                    coordinates.w10Bombable = false;
                    break;

                case "W11":

                    coordinates.w11Bombable = false;
                    break;

                case "W12":

                    coordinates.w12Bombable = false;
                    break;

                case "W13":

                    coordinates.w13Bombable = false;
                    break;

                case "W14":

                    coordinates.w14Bombable = false;
                    break;

                case "W15":

                    coordinates.w15Bombable = false;
                    break;

                case "W16":

                    coordinates.w16Bombable = false;
                    break;

                case "W17":

                    coordinates.w17Bombable = false;
                    break;

                case "W18":

                    coordinates.w18Bombable = false;
                    break;

                case "W19":

                    coordinates.w19Bombable = false;
                    break;

                case "W20":

                    coordinates.w20Bombable = false;
                    break;
                case "X1":

                    coordinates.x1Bombable = false;
                    break;

                case "X2":

                    coordinates.x2Bombable = false;
                    break;

                case "X3":

                    coordinates.x3Bombable = false;
                    break;

                case "X4":

                    coordinates.x4Bombable = false;
                    break;

                case "X5":

                    coordinates.x5Bombable = false;
                    break;


                case "X6":

                    coordinates.x6Bombable = false;
                    break;

                case "X7":

                    coordinates.x7Bombable = false;
                    break;

                case "X8":

                    coordinates.x8Bombable = false;
                    break;

                case "X9":

                    coordinates.x9Bombable = false;
                    break;

                case "X10":

                    coordinates.x10Bombable = false;
                    break;

                case "X11":

                    coordinates.x11Bombable = false;
                    break;

                case "X12":

                    coordinates.x12Bombable = false;
                    break;

                case "X13":

                    coordinates.x13Bombable = false;
                    break;

                case "X14":

                    coordinates.x14Bombable = false;
                    break;

                case "X15":

                    coordinates.x15Bombable = false;
                    break;

                case "X16":

                    coordinates.x16Bombable = false;
                    break;

                case "X17":

                    coordinates.x17Bombable = false;
                    break;

                case "X18":

                    coordinates.x18Bombable = false;
                    break;

                case "X19":

                    coordinates.x19Bombable = false;
                    break;

                case "X20":

                    coordinates.x20Bombable = false;
                    break;
                case "Y1":

                    coordinates.y1Bombable = false;
                    break;

                case "Y2":

                    coordinates.y2Bombable = false;
                    break;

                case "Y3":

                    coordinates.y3Bombable = false;
                    break;

                case "Y4":

                    coordinates.y4Bombable = false;
                    break;

                case "Y5":

                    coordinates.y5Bombable = false;
                    break;


                case "Y6":

                    coordinates.y6Bombable = false;
                    break;

                case "Y7":

                    coordinates.y7Bombable = false;
                    break;

                case "Y8":

                    coordinates.y8Bombable = false;
                    break;

                case "Y9":

                    coordinates.y9Bombable = false;
                    break;

                case "Y10":

                    coordinates.y10Bombable = false;
                    break;

                case "Y11":

                    coordinates.y11Bombable = false;
                    break;

                case "Y12":

                    coordinates.y12Bombable = false;
                    break;

                case "Y13":

                    coordinates.y13Bombable = false;
                    break;

                case "Y14":

                    coordinates.y14Bombable = false;
                    break;

                case "Y15":

                    coordinates.y15Bombable = false;
                    break;

                case "Y16":

                    coordinates.y16Bombable = false;
                    break;

                case "Y17":

                    coordinates.y17Bombable = false;
                    break;

                case "Y18":

                    coordinates.y18Bombable = false;
                    break;

                case "Y19":

                    coordinates.y19Bombable = false;
                    break;

                case "Y20":

                    coordinates.y20Bombable = false;
                    break;
                case "Z1":

                    coordinates.z1Bombable = false;
                    break;

                case "Z2":

                    coordinates.z2Bombable = false;
                    break;

                case "Z3":

                    coordinates.z3Bombable = false;
                    break;

                case "Z4":

                    coordinates.z4Bombable = false;
                    break;

                case "Z5":

                    coordinates.z5Bombable = false;
                    break;


                case "Z6":

                    coordinates.z6Bombable = false;
                    break;

                case "Z7":

                    coordinates.z7Bombable = false;
                    break;

                case "Z8":

                    coordinates.z8Bombable = false;
                    break;

                case "Z9":

                    coordinates.z9Bombable = false;
                    break;

                case "Z10":

                    coordinates.z10Bombable = false;
                    break;

                case "Z11":

                    coordinates.z11Bombable = false;
                    break;

                case "Z12":

                    coordinates.z12Bombable = false;
                    break;

                case "Z13":

                    coordinates.z13Bombable = false;
                    break;

                case "Z14":

                    coordinates.z14Bombable = false;
                    break;

                case "Z15":

                    coordinates.z15Bombable = false;
                    break;

                case "Z16":

                    coordinates.z16Bombable = false;
                    break;

                case "Z17":

                    coordinates.z17Bombable = false;
                    break;

                case "Z18":

                    coordinates.z18Bombable = false;
                    break;

                case "Z19":

                    coordinates.z19Bombable = false;
                    break;

                case "Z20":

                    coordinates.z20Bombable = false;
                    break;
            }
        }
    }
}
