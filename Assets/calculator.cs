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
    private bool dodawanie;
    private bool odejmowanie;
    private bool mno¿enie;
    private bool dzielenie;
    public int mno¿nik = 1;

    public void dodaj()
    {
        mno¿nik = 1;
        dodawanie = true;
        dzia³anie = true;
    }
    public void odejmnij()
    {
        mno¿nik = 1;
        odejmowanie = true;
        dzia³anie = true;
    }
    public void mo¿enie()
    {
        mno¿nik = 1;
        mno¿enie = true;
        dzia³anie = true;
    }
    public void dielenie()
    {
        mno¿nik = 1;
        dzielenie = true;
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
        if(dodawanie)
        {
           wynik = liczba1 + liczba2 ;
        }
        if(odejmowanie)
        {
            wynik = liczba1 - liczba2 ;
        }
        if(mno¿enie)
        {
            wynik = liczba1 * liczba2 ;
        }
        if(dzielenie)
        {
           wynik = liczba1 / liczba2 ;
        }
        mno¿nik = 1;
        dodawanie = odejmowanie = mno¿enie = dzielenie = false;
        pole1.text = wynik.ToString();
        dzia³anie = false;
    }
    public void reset()
    {
        pole1.text = "";
        dodawanie = odejmowanie = mno¿enie = dzielenie = false;
        liczba1 = 0;
        liczba2 = 0;
        mno¿nik = 1;
        dzia³anie = false;
    }
}