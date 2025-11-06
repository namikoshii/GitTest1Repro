/*
Eric Calvo arroyo M7RA1 EXAMEN 1 EXERCICI 1
Crea un script i anomena'l M7RA1EX1NomCognom.cs Escriu un codi (en anglès) que permeti ingressar el nom del mes 
(January, February, March, April, May, June, July, August, September, October, November, December) i ens respongui “You have chosen to be born in the month:[month]”. 
S’ha de tenir en compte l’opció d’escriure malament el mes. 
obligatori utilitzar un Switch.
Exemple: "You have chosen to be born in the month: January".


RESPOSTA: Crearé una string per a posar el nom del mes des del unity i amb un switch per cada mes escric el debug.log.



*/


using UnityEngine;

public class M7RA1EX1EricCalvo : MonoBehaviour
{
    //Creo la string
    public string month;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Faig el switch
        switch (month){
            case "January":
            //Per cada case de l'string faig el debug.log que es demana a l'exercici.
                Debug.Log("You have chosen to be born in the month: " + month);
                break;
            case "February":
                Debug.Log("You have chosen to be born in the month: " + month);
                break;
            case "March":
                Debug.Log("You have chosen to be born in the month: " + month);
                break;
            case "April":
                Debug.Log("You have chosen to be born in the month: " + month);
                break;
            case "May":
                Debug.Log("You have chosen to be born in the month: " + month);
                break;
            case "June":
                Debug.Log("You have chosen to be born in the month: " + month);
                break;
            case "July":
                Debug.Log("You have chosen to be born in the month: " + month);
                break;
            case "August":
                Debug.Log("You have chosen to be born in the month: " + month);
                break;
            case "September":
                Debug.Log("You have chosen to be born in the month: " + month);
                break;
            case "October":
                Debug.Log("You have chosen to be born in the month: " + month);
                break;
            case "November":
                Debug.Log("You have chosen to be born in the month: " + month);
                break;
            case "December":
                Debug.Log("You have chosen to be born in the month: " + month);
                break;
            default:
                Debug.Log("Learn to write the moths correctly and remember to write them using uppercase");
                break;
            //FIN
        }
    }
}
