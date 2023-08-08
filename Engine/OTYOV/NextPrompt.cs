using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Engine.OTYOV {
    internal class NextPrompt {
        private Dictionary<int, List<char>> spacePrompts = new Dictionary<int, List<char>>();
        private Dictionary<string, Prompt> promptDictionary = new Dictionary<string, Prompt>();
        private int currentPosition = 1;

        private class Prompt {
            public string Id { get; set; }
            public string Message { get; set; }
        }
        private void InitializePrompts() {
            // Load prompts from JSON file
            string json = File.ReadAllText("prompts.json");
            var prompts = JsonConvert.DeserializeObject<List<Prompt>>(json);

            // Populate promptDictionary
            foreach (var prompt in prompts) {
                promptDictionary[prompt.Id] = prompt;
            }
        }

        private void btnMoveToNextPrompt_Click(object sender, EventArgs e) {
            int dTen = BetterRandomNumberGenerator.NumberBetween(1, 10);
            int dSix = BetterRandomNumberGenerator.NumberBetween(1, 6);
            int spaces = dTen - dSix;
            int newPosition = currentPosition + spaces;

            if (!spacePrompts.ContainsKey(currentPosition)) {
                spacePrompts[currentPosition] = new List<char> { 'a' };
            } else {
                spacePrompts[currentPosition].Add(GetNextPromptChar(spacePrompts[currentPosition].Last()));
            }

            // If the user lands on the same space 3 times in a row, advance them to the next space.
            if (spacePrompts[currentPosition].Count >= 3) {
                newPosition = GetNextAvailableSpace(newPosition);
            }

            // Ensure the user cannot go below space 1
            if (newPosition < 1) {
                newPosition = 1;
            }

            // Update the current position with the new position.
            currentPosition = newPosition;

            rtbMessages.Text += "You move " + spaces + " spaces " + (spaces >= 0 ? "forward" : "backward") + Environment.NewLine;
        }

        private char GetNextPromptChar(char lastPromptChar) {
            if (lastPromptChar == 'z') {
                return 'a';
            } else {
                return (char)(lastPromptChar + 1);
            }
        }

        private int GetNextAvailableSpace(int position) {
            // Find the next available space that has not been visited 3 times.
            int nextSpace = position + 1;
            char promptChar = 'a';

            while (spacePrompts.ContainsKey(nextSpace) && spacePrompts[nextSpace].Count >= 3) {
                nextSpace++;
            }

            if (spacePrompts.ContainsKey(nextSpace)) {
                promptChar = GetNextPromptChar(spacePrompts[nextSpace].Last());
            }

            spacePrompts[nextSpace] = new List<char> { promptChar };
            return nextSpace;
        }

    }
}
