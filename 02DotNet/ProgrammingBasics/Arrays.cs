using System;
namespace ProgrammingBasics
{

    public class Arrays
    {
        // internal static void SingleDimensional(){
        //     // int[] marks; //declaration
        //     // marks = new int[5]; //initialization
        //     // marks[0] = 67;//adding elements
        //     // marks[3] = 85;
        //     // // for (int i = 0; i < marks.Length; i++){
        //     // //     Console.WriteLine(marks[i]);
        //     // // }
        //     // int[] marks = new int[]{37,80,54,66,98};
        //     // Console.WriteLine($"This array has - {0} elements", marks.Length);
        //     // Console.WriteLine($"This array's rank - {0} elements", marks.Ranks);
        //     // foreach(int mark in marks)
        //     // {
        //         // Console.WriteLine(mark);
        //     }

                        internal static void MultiDimensional() {
                int[,] matrix=new int[2,3]; //use 2 for loops to iterate
                matrix[0,0]=11;
                matrix[0,1]=22;
                matrix[0,2]=33;
                matrix[1,0]=44;
                matrix[1,1]=55;
                matrix[1,2]=66;
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {  
                            Console.WriteLine(matrix[i,j]);
                        }
                    }
                }
                
                
                
                
            
            

            // internal static void JaggedArray() {
            //     int[][] ja = new int[3][]; //initialize row only
            //     ja[0] = new int[]{1,2,3,4}; //row 1
            //     ja[1] = new int[]{5,6,7,8}; //row 2
            //     ja[2]=new int[]{9,0,12,11}; //row 2
            //     Console.WriteLine("Length - {0} and Rank - {1}", ja.Length, ja.Rank);
            //     for (int i = 0; i < ja.Length; i++){
            //         Console.Write($"Row({i})");
            //     for(int j = 0; j < ja[i].Length; j++){
            //         Console.Write(ja[i][j]);
            //     }
            //     Console.WriteLine();
            //     }
            // }
        
    }

}
