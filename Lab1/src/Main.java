import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.nio.charset.StandardCharsets;
import java.util.Arrays;

public class Main {

    public static void main(String[] args) {
        File file = new File("text1.txt");
        System.out.print(getTextFromFile(file));
    }
    public static String getTextFromFile(File file){
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
            return new String(buffer, 0, readBytes);
        } catch (IOException e) {
            e.printStackTrace();
            return Arrays.toString(e.getStackTrace());
        }
    }
}
