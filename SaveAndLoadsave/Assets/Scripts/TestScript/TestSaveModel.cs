using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO ;

public class TestSaveModel : MonoBehaviour
{
    private string DATA_PATH = "/MyGame.dat" ;  //สร้างตัวแปรชื่อว่า DATA_PATH เพื่อเก็บที่อยู่ไฟล์เกมที่บันทึก
    private Player myPlayer ;  //สมมติสร้างตัวละครของเรา
    void Start()
    {
        //การบันทึกข้อมูล โดยใช้ PlayerPrefs

        //PlayerPrefs.SetString("score","40");  บันทึกค่า Score
        //string t = PlayerPrefs.GetString("score");  ดึงค่า score ที่เรา save ไว้มาเก็บไว้ในตัวแปร t
        //Debug.Log(t);

        SaveData(); //เรียกใช้ SaveData เพื่อบันทึก 

        print("Data Paht is " + Application.persistentDataPath + DATA_PATH);  //เช็คดูที่อยู่ไฟล์ที่บันทึก

        // LoadsaveData();

        // if(myPlayer != null)
        // {
        //     print("Name Player : " + myPlayer.Name);
        //     print("HP Player : " + myPlayer.Health);
        //     print("Name Player : " + myPlayer.Levels);

        // }

    }

    void SaveData()
    {
        FileStream file = null ; //กำหนดให้เป็น null ก่อนเพราะว่ามันยังไม่ได้สร้าง
        
        //สร้าง try catch เพื่อที่จะดัก error ในเกม เมื่อมันเกิด error ต่างๆก็จะแจ้งเตือนให้ผู้ใใช้ได้รู้
        try      
        {
            BinaryFormatter bf = new BinaryFormatter();  //ทำการจัด format เลขฐานสอง

            //file = File.Create(Application.persistentDataPath + "/Mygame.dat"); 
            file = File.Create(Application.persistentDataPath + DATA_PATH);  //ที่อยู่ไฟล์ที่บันทึก เอาไปเก็บไว้ในตัวแปร file

            Player me = new Player("Boat",100.0f,99); //สร้างผู้เล่นใหม่(Name : Boat ,HP : 100 , Level : 99 ) เอาไว้ในตัวแปร me

            //****ทำการเข้ารหัสในการบันทึกข้อมูล*****
            bf.Serialize(file,me); 
            //*********************************

            //ถ้าหากไม่มีไฟล์ Game นี้อยู่ ก็จะเเจ้งเตือนไปที่ Catch 

        }
        catch (Exception e)  //แจ้งเตือน error   และเกมก็จะสามารถรันต่อไปได้
        {
            if(e != null)  //ถ้ามี ข้อผิดพลาด
            {
                print("File not found,Please check PATH again.");
            }
        }
        finally  //ที่มี finally เพราะว่าป้องกันการรั่วไหลของข้อมูล
        {
            if(file != null)  //ถ้ามีไฟล์   
            {
                file.Close();  
            }
        }

    }//save data 


    void LoadsaveData()
    {
        FileStream file = null ;
        
        try 
        {
            BinaryFormatter bf = new BinaryFormatter();

            file = File.Open(Application.persistentDataPath + DATA_PATH , FileMode.Open); //ทำการเปิดไฟล์ตามที่อยู่ PATH ที่เราทำการบันทึกไว้

            //************ถอดรหัสข้อมูล หรือ แปลงข้อมูลกลับ*********************
            myPlayer = bf.Deserialize(file) as Player;
            //*************************************************************

        }
        catch (Exception e)
        {
            if(e != null)
            {
                print("File not found,Please check PATH again.");
            }

        }
        finally
        {
            file.Close();
        }

        
    }


}
