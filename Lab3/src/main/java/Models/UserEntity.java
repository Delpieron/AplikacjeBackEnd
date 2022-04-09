package Models;

public class UserEntity {

    private final String name;
    private final String email;
    private final int id;


    public UserEntity(String name, String email, int id) {
        this.name = name;
        this.email = email;
        this.id = id;
    }

    public String getName() {
        return this.name;
    }

}
