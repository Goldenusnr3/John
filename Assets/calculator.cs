using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class calculator : MonoBehaviour
{
    public TMP_Text pole1;

    private float liczba1;
    private float liczba2;
    private float wynik;
    private bool dzia³anie;
    public int mno¿nik = 1;

    public void dodaj()
    {
        mno¿nik = 1;
        dzia³anie = true;
    }
    public void odejmnij()
    {
        mno¿nik = -1;
        dzia³anie = true;
    }
    public void mno¿enie()
    {
        mno¿nik = 1;
        dzia³anie = true;
    }
    public void dzielenie()
    {
        mno¿nik = 1;
        dzia³anie = true;
    }
    public void cyfra(float l)
    {
    

        if (dzia³anie)
        {
            liczba2 += l * mno¿nik;
            pole1.text = liczba2.ToString();
        }
        else
        {
            liczba1 += l * mno¿nik;
            pole1.text = liczba1.ToString();
        }
        mno¿nik *= 10;
    }

    public void Wynik()
    {
        wynik = liczba1 + liczba2;
        pole1.text = wynik.ToString();
    }
}