using System;

namespace LanguageFeatures.Models
{
    public static class MyExtentionMethods
    {//creates an extention method on the String class that double a word when called on a string obj, see example in HomeController
        public static string Twice(this String word)
        {
            string example = word + word;
            return example;
        }
    }
}