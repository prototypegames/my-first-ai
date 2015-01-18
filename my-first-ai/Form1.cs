using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace my_first_ai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RpsGame game = new RpsGame();

        enum Attack
        {
            BLOCK,
            PUNCH,
            JUMP,
            SWEEP
        }

        class RpsGame
        {
            const int SCORE_WIN = 2;
            const int SCORE_SWEEP = 1;
            const int SCORE_DRAW = 0;

            const int PLAYERS = 2;

            Random random = new Random();
            int[] scores = new int[PLAYERS];
            int[] lastResults = new int[PLAYERS];
            Attack[] lastAttacks = new Attack[PLAYERS];

            void ProcessMoves(int attacker, Attack player1, Attack player2)
            {
                int result=0;
                if (player1 == Attack.BLOCK && player2 == Attack.PUNCH)
                    scores[attacker] += result = SCORE_WIN;
                else if (player1 == Attack.PUNCH && player2 == Attack.JUMP)
                    scores[attacker] += result = SCORE_WIN;
                else if (player1 == Attack.JUMP && player2 == Attack.SWEEP)
                    scores[attacker] += result = SCORE_WIN;
                else if (player1 == Attack.SWEEP && player2 == Attack.PUNCH)
                    scores[attacker] += result = SCORE_SWEEP;
                else if (player1 == Attack.SWEEP && player2 == Attack.BLOCK)
                    scores[attacker] += result = SCORE_SWEEP;

                lastResults[attacker] = result;
                lastAttacks[attacker] = player1;


            }

            Attack GetAiMove()
            {
                // select a Move randomly
                var values = Enum.GetValues(typeof(Attack));
                return (Attack)values.GetValue(random.Next(values.Length));
            }

            public void  DoTurn(Attack attack)
            {
                var aiMove = GetAiMove();
                ProcessMoves(0, attack, aiMove);
                ProcessMoves(1, aiMove, attack);
            }

            public int GetPlayerScore()
            {
                return scores[0];
            }
            public int GetAiScore()
            {
                return scores[1];
            }

            public Attack[] GetLastAttacks()
            {
                return lastAttacks;
            }

            public int[] GetLastResults()
            {
                return lastResults;
            }
        }

        private void UpdateScore()
        {
            var results = game.GetLastResults();
            var attacks = game.GetLastAttacks();

            playerAttackLabel.Text = "Attack: " + attacks[0].ToString();
            aiAttackLabel.Text = "Attack: " + attacks[1].ToString();

            playerPointLabel.Text = "Points: " + game.GetPlayerScore().ToString();
            aiPointLabel.Text = "Points: " + game.GetAiScore().ToString();

            playerResultLabel.Text = "Result: " + results[0].ToString() + " " + (results[0] > results[1] ? "(Win)" : "(Lose)");
            aiResultLabel.Text = "Result: " + results[1].ToString() + " " + (results[1] > results[0] ? "(Win)" : "(Lose)");
        }

        private void highBlockButton_Click(object sender, EventArgs e)
        {
            game.DoTurn(Attack.BLOCK);
            UpdateScore();
        }

        private void highPunchButton_Click(object sender, EventArgs e)
        {
            game.DoTurn(Attack.PUNCH);
            UpdateScore();
        }

        private void jumpButton_Click(object sender, EventArgs e)
        {
            game.DoTurn(Attack.JUMP);
            UpdateScore();
        }

        private void sweepButton_Click(object sender, EventArgs e)
        {
            game.DoTurn(Attack.SWEEP);
            UpdateScore();
        }
    }
}
