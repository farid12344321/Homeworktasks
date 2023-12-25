




// See https://aka.ms/new-console-template for more information



#region task1
//Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək 

//Console.WriteLine("Yazi daxil edin");
//string textStr = Console.ReadLine();

//string sum = "";

//for (int i = 0; i < textStr.Length; i++)
//{
//	if (textStr[i] != ' ')
//	{
//		sum += textStr[i];
//	}
//}
//Console.WriteLine(sum);
#endregion


#region task2
//Verilmiş ədədlər siyahısındaki verilmiş n ədədinin yerləşdiyi indexi tapan proqram

//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 89 };

//int item = 89;
//int index = -1;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] == item)
//    {
//        index = i;
//        break;

//    }
//}
//Console.WriteLine(index);
#endregion


#region task3
//Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram

//Console.WriteLine("yazini daxil edin");
//string text = Console.ReadLine();

//Console.WriteLine("herfi daxil edin");
//string letter = Console.ReadLine();


//char letterChar = char.Parse(letter);

//int count = 0;

//for (int i = 0; i < text.Length; i++)
//{
//	if (text[i] == letterChar)
//	{
//		count++;
//	}
//}
//Console.WriteLine(count);



#endregion


#region task4
//Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən proqram
//(Misalçün verilmiş yazı "   salam necesen?   "-dirsə yeni düzələcək string "salam necəsən?   " olmalıdır.


//Console.WriteLine("Yazi daxil edin");
//string textStr = Console.ReadLine();


//string let = "";

//for (int i = 0; i < textStr.Length; i++)
//{
//    if (textStr[i] != ' ')
//    {
//        let += textStr[i];
//    }
//}
//Console.WriteLine(let);


#endregion


#region task5
//Verilmiş 2 ədəd üzərində verilmiş simvola uyğun əməliyyat edən proqram. Simvol +,-,* və ya / olmalıdır,
//əks halda simvolu yenidən daxil edilməsi istənilməlidir.
//(Misaçün simvol * olarsa verilmiş 2 ədəd vurulacaq və nəticəsi göstəriləcək)

//using System;

//Console.WriteLine("1 ededi daxil edin");
//string num1str = Console.ReadLine();
//int num1 = Convert.ToInt32(num1str);

//Console.WriteLine("2 ededi daxil edin");
//string num2str = Console.ReadLine();
//int num2 = Convert.ToInt32(num2str);


//bool check;
//int result = 0;
//do
//{
//    Console.WriteLine("operator daxil edin");
//    string operation = Console.ReadLine();
//	check = true;


//    switch (operation)
//	{
//		case "+":
//			result = num1 + num2;
//			break;
//		case "-":
//			result = num1 - num2;
//			break;
//		case "*":
//			result = num1 * num2;
//			break;
//		case "/":
//			result = num1 / num2;
//			break;
//		default:
//            check = false;
//            Console.WriteLine("Operator novu yanlisdir");
//            break;
//	}
//} while (!check);


//Console.WriteLine(result);






#endregion
