package com.example.Service;

import com.example.Model.Car;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

@Service
public class CarService {
    private List<Car> carList = new ArrayList<>();

    public List<Car> getAllCars() {
        return carList;
    }

    public Optional<Car> getCarById(Long id) {
        return carList.stream().filter(car -> car.getId().equals(id)).findFirst();
    }

    public Car saveCar(Car car) {
        if (car.getId() == null) {
            car.setId(System.currentTimeMillis());
            carList.add(car);
        } else {
            for (int i = 0; i < carList.size(); i++) {
                if (carList.get(i).getId().equals(car.getId())) {
                    carList.set(i, car);
                    break;
                }
            }
        }
        return car;
    }

    public void deleteCar(Long id) {
        carList.removeIf(car -> car.getId().equals(id));
    }
}
