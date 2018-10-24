import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AirplaneViewModel } from '../models/AirplaneViewModel';

@Injectable()
export class AirplaneService {
  baseUrl: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

    //alert(baseUrl);
    this.baseUrl = baseUrl + 'api/Airplane/';
  }

  getAirplanes() {
    return this.http.get<AirplaneViewModel[]>(this.baseUrl);
  }

  getAirplaneById(id: string) {
    return this.http.get<AirplaneViewModel>(this.baseUrl + id);
  }

  createAirplane(airplane: AirplaneViewModel) {
    var formData = new FormData();
    formData.append("airplane", JSON.stringify(airplane));
    return this.http.post(this.baseUrl + 'CreateAirplane', formData);
  }

  updateAirplane(airplane: AirplaneViewModel) {
    var formData = new FormData();
    formData.append("airplane", JSON.stringify(airplane));
    return this.http.put(this.baseUrl, formData);
  }

  deleteAirplane(id: string) {
    return this.http.delete(this.baseUrl + id);
  }
}
