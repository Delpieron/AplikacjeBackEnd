import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.time.Instant;
import java.util.Date;
import java.util.TimeZone;

public class Main5 {

    public static void main(String[] args) {
        Date date = new Date();

        DateFormat df = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
        df.setTimeZone(TimeZone.getTimeZone("Europe/Warsaw"));

        System.out.println("Local date is: " + df.format(date));

        Instant globalDateTime = Instant.now();
        System.out.println("Global date is " + globalDateTime);
    }
}
