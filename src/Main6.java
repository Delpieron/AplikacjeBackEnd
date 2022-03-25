import java.io.File;

public class Main6 {
  public static void main(String[] args) {
    File file = new File("text2.txt");

    String text = Main.getTextFromFile(file);
    var elementsList = text.split(";");

    for (int i = 0; i < elementsList.length; i++) {
      System.out.println(i + ". " + elementsList[i]);
    }
  }
}
