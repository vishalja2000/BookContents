﻿// Chapter 3.6 White Space

class WhiteSpace {
    /*
     * Section 3.6 White Space
     * The function below has normal white space added
     */
    void MyFunction()
    {
        int i = 0;
        while (i < 10)
        {
            System.Console.Write(i);
            i++;
        }
    }

    /*
     * Section 3.6 White Space
     * The function below has minimal white space added
     * the only place white space is required is after a
     * keyword is used to name a variable.
     * for instance after void and after int
     * the function works, it's just a bit difficult to read.
     */
void MyOtherFunction(){int i=0;while(i<10){System.Console.Write(i);i++;}
    }

    /*
     * Section 3.6.1 Code Style
     *
     *    ┌──────────────────────────────┐
     *    │ The placement of the first { │
     *    │ appearing on the first line  │
     *    └────────────────┬─────────────┘
     *                     │
     * void SomeFunction() {
     *    // Some Code here...
     * }
     *
     * Perhaps the above is more compact.
     * 
     * void SomeOtherFunction()
     * {
     *    // Some Code here...
     * }
     * └──────┐
     * ┌──────┴───────────────────────┐
     * │ The placement of the first { │
     * │ appearing on the second line │
     * └──────────────────────────────┘
     */

    void SomeFunction() {
        // Some Code here...
    }

    void SomeOtherFunction()
    {
        // Some Other Code here...
    }
}
