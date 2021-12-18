using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SpicyWater
{
    public class CrankGame : MonoBehaviour
    {
        public Text UIText;
        public string startText;
        public string winText;
        public int crankMax;
        public int crankCurrent;
        public float crankStep;
        public int letterPos;
        public string[] crankSequence = new string[]{ "W", "A", "S", "D" };
        // Start is called before the first frame update
        void Start()
        {
            UIText.text = startText;
            MinigameManager.Instance.minigame.gameWin = false;
            crankCurrent = 0;
            if( crankMax != 0)
                crankStep = 1 / crankMax;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(crankSequence[letterPos]))
            {
                if (letterPos >= crankSequence.Length)
                    letterPos = 0;
                else letterPos++;
            }

        }
    }
}