import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Router } from '@angular/router';
import { first } from "rxjs/operators";
import { AirplaneService } from '../../services/airplaneservice';

@Component({
  selector: 'app-airplane',
  templateUrl: './add-airplane.component.html'
})
export class AddAirplaneComponent implements OnInit {
  constructor(private formBuilder: FormBuilder, private router: Router, private service: AirplaneService) { }

  addForm: FormGroup;

  ngOnInit() {

    

    this.addForm = this.formBuilder.group({
      Id :[],
      CodigoAviao: ['', Validators.required],
      Modelo: ['', Validators.required],
      Passageiros: ['', Validators.required],
      DataRegistro: ['', Validators.required]
    });   
  }

  onSubmit() {
    this.service.createAirplane(this.addForm.value)
      .subscribe(data => {
        this.router.navigate(['list-airplane']);
      });
  }
}
