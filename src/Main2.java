import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.OutputStreamWriter;
import java.nio.charset.StandardCharsets;

public class Main2 {

    public static void main(String[] args) throws FileNotFoundException {
        String text = "dsadsadsa  dsadsa";
        try (
                FileOutputStream outStream = new FileOutputStream("text1.txt");
                OutputStreamWriter outputStream = new OutputStreamWriter(outStream, StandardCharsets.UTF_8)

        ) {
            outputStream.write(text);
            outputStream.flush();
        } catch (IOException e) {
            e.printStackTrace();
        }

    }
}
