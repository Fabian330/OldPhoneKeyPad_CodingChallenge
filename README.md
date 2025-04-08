# OldPhoneKeyPad_CodeChallenge
This code of this project works like and Old Phone Key Pad.
For example if your input is "27 755533#".
The output will be: "APPLE".

But make sure you use it the right way, because if you look at the space between the '7'
maybe you'll notice that you have to specify when you want to start with a new letter,
also notice the '#' at then end of the example, without you won't receive an ouput
because the message(input) won't be sent.

In the other hand you also have to make sure you don't exceed the max range of the numbers,
for example if you type "222" that letter will be "C" but if you type "2222" that will be out of range,
in that case you should use a space "222 2" = "CA", same happens with "7" or "9" but those numbers
allow one more character so you can type one more time "9999" = "Z" but "99999" will be an error.

Aditional characters:
- To delete a letter = "*"
input is "27 755533**#" and output = "APP"

- To add a space between the letters = "0"
input is "27 7055533#" and output = "APP LE"

- To add a comma between the letters = "1"
input is "27 7155533#" and output = "APP,LE"

And you can combine them
input is "44 4441027 79* 55533#" and output = "HI, APPLE"
notice the "9*" I intentionally added a "W" but I deleted it with "*" 
