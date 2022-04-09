package Services;

import org.springframework.stereotype.Service;

import javax.annotation.PostConstruct;
import javax.annotation.PreDestroy;

@Service
public class UsersService {

    // ...

    @PostConstruct
    private void onCreate() {
        // wczytywanie uzytkowników
    }

    @PreDestroy
    private void onDestroy() {
        // zapisywanie uzytkowników
    }

    // ...
}