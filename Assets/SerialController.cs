using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.IO.Ports;

public class SerialController : MonoBehaviour
{
    // Start is called before the first frame update
    public static SerialPort sp = new SerialPort ("COM3", 9600);
    public string message;
    void Start()
    {
        Connect();
    }

    // Update is called once per frame
    void Update()
    {
        message = sp.ReadLine();
		//print(message2);
    }

    public void Connect(){
        
       if (sp != null) 
        {
            if (sp.IsOpen) 
            {
                sp.Close();
                print("Closing port, because it was already open!");
            }
            else 
            {
                sp.Open();  // opens the connection
                sp.ReadTimeout = 16 ;  // sets the timeout value before reporting error
                print("Port Opened!");
                //		message = "Port Opened!";
            }
        }
        else
        {
            if (sp.IsOpen)
            {
                print("Port is already open");
            }
            else 
            {
                print("Port == null");
            }
        }
    }
    public static void Send(string code){
      sp.Write(code);
    }

    //when the appplication ends close the conection with the arduino
    public void OnApplicationQuit(){
        sp.Close();
    }
}
