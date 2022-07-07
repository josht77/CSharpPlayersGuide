// See https://aka.ms/new-console-template for more information
countDown(10);
int countDown(int start) {
    Console.WriteLine(start);
    if (start == 1) {
        return 1;
    } 
    return countDown(start - 1);
}


