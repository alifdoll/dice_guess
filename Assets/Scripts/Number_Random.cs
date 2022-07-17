using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// using System;

public class Number_Random : MonoBehaviour
{

    public enum State
    {
        START,
        PLAY,
        ROLL,
        GUESS,
        REPLAY
    }
    [SerializeField] public State game_state = State.START;
    [SerializeField] public TMP_Text number_text;
    [SerializeField] public TMP_InputField answer_input;
    // Start is called before the first frame update
    void Start()
    {
        game_state = State.PLAY;
        StartGame();
    }

    private void StartGame()
    {
        int number = Random.Range(0, 6);
        number_text.text = number.ToString();
    }

    public void Check()
    {
        if (game_state == State.PLAY)
        {
            if (answer_input.text.ToString() == number_text.text.ToString())
            {
                number_text.text = "Correct";
            }
            else
            {
                number_text.text = "Incorrect";

            }
            game_state = State.REPLAY;
        }
        else if (game_state == State.REPLAY)
        {
            StartGame();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
