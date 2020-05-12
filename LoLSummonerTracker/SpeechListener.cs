using System;
using System.Speech.Recognition;

namespace LoLSummonerTracker
{
    public class SpeechListener
    {

        GUI gui;
        SpeechRecognitionEngine recognizer;
        bool activated;

        public SpeechListener(GUI gui) { 
            this.gui = gui;

            activated = false;
        }

        public void StartListening() {
            
            // Create an in-process speech recognizer for the en-US locale
            recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));

            Choices choiceList = new Choices();
            if (!activated)
            {
                choiceList.Add(new string[] { "monkey"});
            }

            else { choiceList.Add(new string[] { "top" , "jungle", "middle" , "bottom" , "support" }); }

            GrammarBuilder grammarBuilder = new GrammarBuilder();
            grammarBuilder.Culture = new System.Globalization.CultureInfo("en-US");
            grammarBuilder.Append(choiceList);

            Grammar grammar = new Grammar(grammarBuilder);

                // Create and load a dictation grammar.  
                recognizer.LoadGrammar(grammar);

                // Add a handler for the speech recognized event.  
                recognizer.SpeechRecognized +=
                  new EventHandler<SpeechRecognizedEventArgs>(Recognizer_SpeechRecognized);

                // Configure input to the speech recognizer.  
                recognizer.SetInputToDefaultAudioDevice();

                // Start asynchronous, continuous speech recognition.  
                recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        public void StopListening() {
            recognizer.Dispose();
        }

        // Handle the SpeechRecognized event.  
        public void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "monkey")
            {
                activated = true;
            }

            else {

                switch (e.Result.Text) {

                    case "top":
                        gui.SummonerUsed("top");
                        break;


                    case "jungle":
                        gui.SummonerUsed("jungle");
                        break;


                    case "middle":
                        gui.SummonerUsed("middle");
                        break;


                    case "bottom":
                        gui.SummonerUsed("bottom");
                        break;


                    case "support":
                        gui.SummonerUsed("support");
                        break;

                }

                activated = false;
            
            }

            gui.setLabel("Recognized text: " + e.Result.Text);

            StopListening();
            StartListening();
        }

    }
}
