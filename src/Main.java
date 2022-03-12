import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.nio.charset.StandardCharsets;

public class Main {

    public static void main(String[] args) {
        File file = new File("text1.txt");
        try (
                FileInputStream inputStream = new FileInputStream(file);
                InputStreamReader fileReader = new InputStreamReader(inputStream, StandardCharsets.UTF_8)
        ) // UTF-8
        {
            int length = (int) file.length();
            char[] buffer = new char[length];
            int readBytes = fileReader.read(buffer, 0, buffer.length);
            if (readBytes != length) {
                throw new IOException("File reading error");
            }
            String text = new String(buffer, 0, readBytes);
            System.out.print(text);

        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
