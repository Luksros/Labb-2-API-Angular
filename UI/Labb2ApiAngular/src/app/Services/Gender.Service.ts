import {HttpClient} from "@angular/common/http";
import {Gender} from '../Models/Gender.Model';
import {Injectable} from '@angular/core';
import { Observable } from "rxjs";

@Injectable({
    providedIn: 'root' 
})

export class GenderService{
    baseUrl='https://localhost:7182/api/genders'
    constructor(private http:HttpClient){ }

    getAllGenders() : Observable<Gender[]>{
        return this.http.get<Gender[]>(this.baseUrl);
    }

    getGenderById(id:string) : Observable<Gender>{
        return this.http.get<Gender>(this.baseUrl + '/'+ id)
    }
}