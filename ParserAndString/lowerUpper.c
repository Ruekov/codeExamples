/*
 * Converts the first letter after a space character ' ' to Upper letter.
 * 
 */


#include <stdio.h>
#include <ctype.h>
#include <stdlib.h>
#include <string.h>

char *OnlyCapitalLetterAfterSpace(char *string_input){
	
	
	int len = 0;
	int letter_string = 1;
    len = strlen(string_input);
	char *return_string = malloc(len + 1);
	
	if (string_input[0] != ' '){
		
		return_string[0] = toupper(string_input[0]);

		}
	
	while (string_input[letter_string] != '\0'){
		
		if(string_input[letter_string-1] == ' '){
			
			return_string[letter_string] = toupper(string_input[letter_string]);
			
		}else{
			
			return_string[letter_string] = tolower(string_input[letter_string]);	
				
			}
		
		letter_string++;
		
		}
		
	  return return_string;
	
	}

int main(int argc, char **argv)
{
	char *test1 = "hola com estas y tal y cual";
	char *test2 = OnlyCapitalLetterAfterSpace(test1);
	
	char *test3 = "yo juego al baloncesto, me gusta la NBA y la ACB";
	char *test4 = OnlyCapitalLetterAfterSpace(test3);
	
	char *test5 = "ONU   USA   FMI   NATO";
	char *test6 = OnlyCapitalLetterAfterSpace(test5);
	
	char *test7 = "A a b B C c d D e E";
	char *test8 = OnlyCapitalLetterAfterSpace(test7);
	
	printf("%s \n",test1);
	printf("%s \n",test2);
	
	printf("%s \n",test3);
	printf("%s \n",test4);
	
	printf("%s \n",test5);
	printf("%s \n",test6);
	
	printf("%s \n",test7);
	printf("%s \n",test8);

	return 0;
}

