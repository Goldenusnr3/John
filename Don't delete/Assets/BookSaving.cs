using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;
using System;
using Unity.VisualScripting;
using System.Collections.Generic;

public class BookSaving : MonoBehaviour
{
    public TMP_InputField imieinazwisko;
    public TMP_InputField bookname;
    public List<string>books = new List<string>();
    public List<string>users = new List<string>();
    public void bookreset()
    {
        imieinazwisko.text = "";
        bookname.text = "";
    }
    public void savebook()
    {

        var isOnList = books.Find(b => b == bookname.text); //SprawdŸ czy jest na liœcie
        if (isOnList == null)
        {
            books.Add(bookname.text);  //Dodaj do listy
        }
        else
        {
            Debug.Log("Taka ksi¹¿ka ju¿ istnieje");
        }
        //je¿eli jest to nie dodawaj tylko poinformuj u¿ytkownika
       

    }
    public void saveuser()
    {
        var isOnList = users.Find(u => u == imieinazwisko.text);
        if (isOnList == null)
        {
            users.Add(imieinazwisko.text);
        }
        else
        {
            Debug.Log("Taka osoba ju¿ istnieje");
        }
    }
    public void printallbooks()
    {
        foreach (string book in books)
        {
            Debug.Log(book);
        }
    }
    public void savetofile()
    {
        StreamWriter savebooks = new StreamWriter("bookssavefile.txt");//stworzyæ plik
        foreach (string book in books)
        {
            savebooks.WriteLine(book);//wpisaæ ca³¹ liste
        }
        savebooks.Close();//zamkn¹æ plik

        StreamWriter saveusers = new StreamWriter("userssavefile.txt");
        foreach (string user in users)
        {
            saveusers.WriteLine(user);
        }
        saveusers.Close();
    }
    public void readfromfile()
    {
        String line;

        StreamReader readbooks = new StreamReader("bookssavefile.txt");
        line = readbooks.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            line = readbooks.ReadLine();
        }
        readbooks.Close();
        Console.ReadLine();

        StreamReader readusers = new StreamReader("userssavefile.txt");
        line = readusers.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            line = readusers.ReadLine();
        }
        readusers.Close();
        Console.ReadLine();
    }
}

