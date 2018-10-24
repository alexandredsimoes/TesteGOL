import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AirplaneViewModel } from '../../models/AirplaneViewModel';
import { AirplaneService } from '../../services/airplaneservice';
import { Router } from '@angular/router';

@Component({
  selector: 'app-airplane',
  templateUrl: './list-airplane.component.html'
})
export class AirplaneComponent {
  public airplanes: AirplaneViewModel[];
  _service: AirplaneService;

  constructor(http: HttpClient, private service: AirplaneService, private router: Router,
    @Inject('BASE_URL') baseUrl: string)
  {
    this._service = service;
    service.getAirplanes().subscribe(result => {
      this.airplanes = result;
    }, error => console.error(error));
  }

  removeAirplane(airplane: AirplaneViewModel): void {
    this._service.deleteAirplane(airplane.id)
      .subscribe(data => {
        this.airplanes = this.airplanes.filter(i => i !== airplane);
      })
  };

  editAirplane(airplane: AirplaneViewModel): void {
    localStorage.removeItem("editAirplaneId");
    localStorage.setItem("editAirplaneId", airplane.id);
    this.router.navigate(['edit-airplane']);
  };
}


