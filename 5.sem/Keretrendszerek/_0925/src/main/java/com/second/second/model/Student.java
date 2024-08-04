package com.second.second.model;

public class Student
{
    private String id;
    private String name;
    private String description;
    private List<Course>
}
package com.example.carmanagement.service;

        import com.example.carmanagement.model.Car;
        import com.example.carmanagement.repository.CarRepository;
        import org.springframework.beans.factory.annotation.Autowired;
        import org.springframework.stereotype.Service;

        import java.util.List;
        import java.util.Optional;

@Service
public class CarService {
    @Autowired
    private CarRepository carRepository;

    public List<Car> getAllCars() {
        return carRepository.findAll();
    }

    public Optional<Car> getCarById(Long id) {
        return carRepository.findById(id);
    }

    public Car saveCar(Car car) {
        return carRepository.save(car);
    }

    public void deleteCar(Long id) {
        carRepository.deleteById(id);
    }
}

-----------
package com  .example.carmanagement.controller;

        import com.example.carmanagement.model.Car;
        import com.example.carmanagement.service.CarService;
        import org.springframework.beans.factory.annotation.Autowired;
        import org.springframework.stereotype.Controller;
        import org.springframework.ui.Model;
        import org.springframework.web.bind.annotation.*;

@Controller
@RequestMapping("/cars")
public class CarController {
    @Autowired
    private CarService carService;

    @GetMapping
    public String getAllCars(Model model) {
        model.addAttribute("cars", carService.getAllCars());
        return "car/list";
    }

    @GetMapping("/{id}")
    public String getCarById(@PathVariable Long id, Model model) {
        carService.getCarById(id).ifPresent(car -> model.addAttribute("car", car));
        return "car/detail";
    }

    @GetMapping("/new")
    public String showCarForm(Model model) {
        model.addAttribute("car", new Car());
        return "car/form";
    }

    @PostMapping("/new")
    public String saveCar(@ModelAttribute Car car) {
        carService.saveCar(car);
        return "redirect:/cars";
    }

    @GetMapping("/edit/{id}")
    public String showEditForm(@PathVariable Long id, Model model) {
        carService.getCarById(id).ifPresent(car -> model.addAttribute("car", car));
        return "car/form";
    }

    @PostMapping("/edit/{id}")
    public String updateCar(@PathVariable Long id, @ModelAttribute Car car) {
        carService.saveCar(car);
        return "redirect:/cars";
    }

        @GetMapping("/delete/{id}")
        public String deleteCar(@PathVariable Long id) {
            carService.deleteCar(id);
            return "redirect:/cars";
    }
}
--
package com.example.carmanagement.model;

        import javax.persistence.Entity;
        import javax.persistence.GeneratedValue;
        import javax.persistence.GenerationType;
        import javax.persistence.Id;

@Entity
public class Car {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String licensePlate;
    private String manufacturer;
    private String model;
    private int horsepower;

    // getterek, setterek, stb.
}

package com.example.carmanagement.repository;

        import com.example.carmanagement.model.Car;
        import org.springframework.data.jpa.repository.JpaRepository;

public interface CarRepository extends JpaRepository<Car, Long> {
}


