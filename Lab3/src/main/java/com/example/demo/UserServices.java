package com.example.demo;

import org.springframework.stereotype.Service;

@Service
public class UserServices {
    public String getUsers(){
        return "Maciek, Arek, Jarek";
    }
}
