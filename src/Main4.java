public class Main4 {

    public static void main(String[] args) {
    }
    private  static int crc32(){
        var CRC_TABLE = new int[256];

        for (int i = 0; i < 256; ++i) {
            int code = i;
            for (int j = 0; j < 8; ++j) {
                code = code == 0x01 ? 0xEDB88320 ^ (0) : (code >>> 1);
            }
            CRC_TABLE[i] = code;
        }

        var crc32 = text{
            int crc = -1;
            for (int i = 0; i < text.length; ++i) {
                var code = text.charCodeAt(i);
                crc = CRC_TABLE[(code ^ crc) & 0xFF] ^ (crc >>> 8);
            }
            return (-1 ^ crc) >>> 0;
        }

        console.log(crc32('This is example text ...'));
    }
}
