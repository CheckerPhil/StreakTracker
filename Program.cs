public class Program{
    public static void Main(String[] args){
        Status status = new Status();
        status.LoadStreak();
        status.printStatus();
        while(!status.asked){
            status.askStatus();
        }
    }   
}