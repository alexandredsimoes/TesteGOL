import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Router } from '@angular/router';
import { AirplaneService } from '../../services/airplaneservice';
import { AirplaneViewModel } from '../../models/AirplaneViewModel';
import { first } from "rxjs/operators";
import moment = require('moment');

@Component({
  selector: 'app-airplane',
  templateUrl: './edit-airplane.component.html'
})
export class EditAirplaneComponent implements OnInit {

  airplane: AirplaneViewModel;
  editForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private router: Router, private service: AirplaneService) { }

  ngOnInit() {    
    let id = localStorage.getItem("editAirplaneId");
    if (!id) {
      alert("Nenhum item selecionado.")
      this.router.navigate(['list-airplane']);
      return;
    }

    this.editForm = this.formBuilder.group({
      Id :[],
      CodigoAviao: ['', Validators.required],
      Modelo: ['', Validators.required],
      Passageiros: ['', Validators.required],
      DataRegistro: ['', Validators.required]
    });

    this.service.getAirplaneById(id)
      .subscribe(data => {

        var d = new Date(data.dataRegistro.toString()).toISOString();

        this.editForm.controls.CodigoAviao.setValue(data.codigoAviao);
        this.editForm.controls.DataRegistro.setValue(moment(data.dataRegistro).format('DD/MM/YYYY'));
        this.editForm.controls.Id.setValue(data.id);
        this.editForm.controls.Modelo.setValue(data.modelo);
        this.editForm.controls.Passageiros.setValue(data.passageiros);
      });
  }

  onSubmit() {
    this.service.updateAirplane(this.editForm.value)
      .pipe(first())
      .subscribe(data => {
        this.router.navigate(['list-airplane']);
      });
  }
}
