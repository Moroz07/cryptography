using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public class CaesarAnimation
    {
        private Timer animationTimer;
        private int currentStep;
        private string originalText;
        private string encryptedText;
        private RichTextBox targetTextBox;
        private int animationSpeed = 200;

        public void StartAnimation(string original, string encrypted, RichTextBox target)
        {
            originalText = original;
            encryptedText = encrypted;
            targetTextBox = target;
            currentStep = 0;
            targetTextBox.Text = "";

            animationTimer = new Timer();
            animationTimer.Interval = animationSpeed;
            animationTimer.Tick += OnTimerTick;
            animationTimer.Start();
        }

        public void StopAnimation()
        {
            if (animationTimer != null)
            {
                animationTimer.Stop();
                animationTimer.Dispose();
                animationTimer = null;
            }
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if (currentStep < encryptedText.Length)
            {
                targetTextBox.Text += encryptedText[currentStep];
                currentStep++;
            }
            else
            {
                StopAnimation();
            }
        }
    }    
}
