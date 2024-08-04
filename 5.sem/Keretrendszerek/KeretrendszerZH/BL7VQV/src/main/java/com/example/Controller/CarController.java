package com.example.Controller;

import com.example.Model.Car;
import com.example.Service.CarService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@Controller
@RequestMapping("/cars")
public class CarController {
    @Autowired
    private CarService carService;

    @GetMapping
    public String getAllCars(Model model) {
        List<Car> cars = carService.getAllCars();
        model.addAttribute("cars", cars);
        return "list";
    }

    @GetMapping("/{id}")
    public String getCarById(@PathVariable Long id, Model model) {
        Car car = carService.getCarById(id).orElse(null);
        model.addAttribute("car", car);
        return "detail";
    }

    @GetMapping("/new")
    public String showCarForm(Model model) {
        model.addAttribute("car", new Car());
        return "form";
    }

    @PostMapping("/new")
    public String saveCar(@ModelAttribute Car car) {
        carService.saveCar(car);
        return "redirect:/cars";
    }

    @GetMapping("/edit/{id}")
    public String showEditForm(@PathVariable Long id, Model model) {
        Car car = carService.getCarById(id).orElse(null);
        model.addAttribute("car", car);
        return "form";
    }

    @GetMapping("/delete/{id}")
    public String deleteCar(@PathVariable Long id) {
        carService.deleteCar(id);
        return "redirect:/cars";
    }
}
