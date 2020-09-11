import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs"; 
import { Company } from '../Models/company';
@Injectable({
  providedIn: 'root'
})
export class AdminService {
  path:string = "http://localhost:62252/Admin/";
  constructor(private http:HttpClient) { }
  public GetAll():Observable<Company[]>{
    return this.http.get<Company[]>(this.path + "GetAllCompanies");
  }
  public Get(companyCode:string):Observable<Company>
  {
    return this.http.get<Company>(this.path + "GetAllCompany/" + companyCode);
  }
  public Add(item:Company):Observable<any>{
    console.log(item);
    return this.http.post<any>(this.path+"AddCompany",item);
  }
  public Update(item:Company):Observable<any>{
    console.log(item);
    return this.http.put<any>(this.path+"EditCompany",item);
  }
  public Delete(code:string):Observable<any>{
    console.log(code);
    return this.http.delete<any>(this.path+"DeleteCompany/"+code);
  }
}
