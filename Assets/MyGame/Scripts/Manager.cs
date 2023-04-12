using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

 public enum Artefakt
    {
        Schere = 0,
        Stein = 2, 
        Papier = 1
    }

public class Manager : MonoBehaviour
{
    [SerializeField] private Image computer, player;
    [SerializeField] private Text gewonnenText;
    [SerializeField] private Text punkteText;

    private int round, pScore, cScore;

    public Artefakt schere = Artefakt.Schere;
    public Artefakt papier = Artefakt.Papier;
    public Artefakt stein = Artefakt.Stein;

    /*bei Btn Press: Schere Stein Papier spielen
     * P Random Schere Stein Papier wählen
     * C Random Schere Stein Papier wählen
     * Auswerten wer gewonnen hat
     * Message hinschreiben wer gewonnen hat
     * -> Audio
    */

    public void PlayGame()
    {
        //Debug.Log("gedrückt");
        round++; 
        //Schere Rot (0), Papier Grün (1), Stein Blau (2), 

        computer.GetComponent<Image>().color = Color.red;
        player.color = Color.blue;

        int rndC = Random.Range(0, 3);
        int rndP = Random.Range(0, 3);

        

        if (rndC == 0)
        {
            computer.color = Color.red; 
        }
        if (rndC == 1)
        {
            computer.color = Color.green;
        }
        if (rndC == 2)
        {
            computer.color = Color.blue;
        }


        if (rndP == 0)
        {
            player.color = Color.red;
        }
        if (rndP == 1)
        {
            player.color = Color.green;
        }
        if (rndP == 2)
        {
            player.color = Color.blue;
        }


        if (artefact == Artefakt.Schere)
        {
            
        }


        if (rndP == 0 && rndC == 1)
        {
            //Debug.Log("Player Gewinnt");
            pScore++;
        }

        if (rndP == 1 && rndC == 2)
        {
            //Debug.Log("Player Gewinnt");
            pScore++;
        }

        if (rndP == 2 && rndC == 0)
        {
            //Debug.Log("Player Gewinnt");
            pScore++;
        }


        if (rndC == 0 && rndP == 1)
        {
            //Debug.Log("Computer Gewinnt");
            cScore++;
        }

        if (rndC == 1 && rndP == 2)
        {
            //Debug.Log("Computer Gewinnt");
            cScore++;
        }

        if (rndC == 2 && rndP == 0)
        {
            //Debug.Log("Computer Gewinnt");
            cScore++;
        }


        if (rndC == rndP)
        {
            //Debug.Log("unentschieden");
        }
    }

   

    void Start()
    {
        
    }

    void Update()
    {
        punkteText.text = "ROUND " + round + "  Computer: " + cScore + "   Player: " + pScore; 

        if (round == 5)
        {
            if (pScore > cScore)
            {
                //Debug.Log("OMG PLAYER GEWINNT!!!");
                gewonnenText.text = "Player!";
            }
            else if (pScore < cScore) 
            {
                //Debug.Log("OMG COMPUTER GEWINNT!!!");
                gewonnenText.text = "Computer!";
            }
            else
            {
                //Debug.Log("lol unentschieden?!");
                gewonnenText.text = "keiner"; 
            }

            round = 0;
            pScore = 0;
            cScore = 0; 
        }


    }
}
