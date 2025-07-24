This is the test assignment for keypad mapping from IRON Software, and I’ll explain my solution. The logic is handled inside a method called OldPhonePad, which takes an input string. This string represents key presses on an old mobile keypad. At the start of the function, I’ve defined a dictionary that maps digits from 2 to 9 to their corresponding letters, like 2 maps to “ABC”, 3 to “DEF”, and so on, using a loop and a predefined array.

Once the mapping is set up, I use a for loop to go through each character in the input string. For each character, I check what type it is. It could be a number key, a space, a backspace (*), or a send (#). If it’s a digit, I check how many times it repeats in a row. This tells me which letter from that digit’s group we’re trying to type. For example, pressing 4 three times means we want the third letter from that key, which is I. I track this with a repeat_count and advance the loop accordingly.

If I encounter a space, I just ignore it. It’s used to separate presses on the same key. If I hit a *, that’s backspace. I simply remove the last character from the current result, as long as it’s not empty. If I hit a 0, I append a space. And if I hit a #, that means the message is done, so I break out of the loop and return the result.

I’ve also added test cases inside the Main method. These include both given test cases and some of my own custom ones to verify that the logic handles edge cases like backspacing, spaces, and different key combinations. The custom ones spell out words like “IRON SOFTWARE” and “AHMAD SOHAIL” using the correct digit sequences. The result gets built using a StringBuilder, and overall, this approach ensures that we translate keypress sequences properly.

One important thing to note is that what if the user presses 2 more than 3 times without a pause? Would it cycle back to 'A'? This was not addressed in the solution, but a question I had of my own.
[24th July, RESOLVED]
