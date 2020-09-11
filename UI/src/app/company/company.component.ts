import { Component, OnInit } from '@angular/core';
import { Company } from '../Models/company';
import { AdminService } from '../Shared/admin.service';

@Component({
  selector: 'app-company',
  templateUrl: './company.component.html',
  styleUrls: ['./company.component.css']
})
export class CompanyComponent implements OnInit {
list:Company[];
companyCode:string;
companyName:string;
ceo:string;
turnOver:string;
board:string;
stockCode:string;
writeUp:string;
obj:Company;
  constructor(private service:AdminService) {
    this.service.GetAll().subscribe(i=>{
      this.list=i;
      console.log(this.list);
    });
   }

  ngOnInit(): void {
  }
  public Search(){
    this.service.Get(this.companyCode).subscribe(item=>{
      this.obj=item;
      console.log(this.obj);
      this.companyCode = this.obj.companyCode;
      this.companyName = this.obj.companyName;
      this.ceo = this.obj.ceo;
      this.board = this.obj.board;
      this.stockCode = this.obj.stockCode;
      this.turnOver = this.obj.turnOver;
    })
  }
  public Add(){
    this.obj = {
      companyCode:this.companyCode,
      companyName:this.companyName,
      ceo:this.ceo,
      board:this.board,
      stockCode:this.stockCode,
      turnOver:this.turnOver,
      writeUp:this.writeUp
    };
    this.service.Add(this.obj).subscribe(i=>{
      console.log(i);
    })
  }
  public Update(){
    this.obj = {
      companyCode:this.companyCode,
      companyName:this.companyName,
      ceo:this.ceo,
      board:this.board,
      stockCode:this.stockCode,
      turnOver:this.turnOver,
      writeUp:this.writeUp
    };
    this.service.Update(this.obj).subscribe(i=>{
      console.log(i);
    })
  }
  public Delete(){
    this.service.Delete(this.companyCode).subscribe(res=>{
      console.log(res);
    })
  }
}
// "An error occurred while updating the entries. See the inner exception for details."