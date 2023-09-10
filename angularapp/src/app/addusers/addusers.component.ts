import { HttpClient } from '@angular/common/http';
import { Component, ElementRef, ViewChild } from '@angular/core';
import { Routes, Router } from '@angular/router';
import { HttpService } from '../http.service';
@Component({
  selector: 'app-root',
  templateUrl: './addusers.component.html',
  styleUrls: ['./addusers.component.css']
})

export class AddUsersComponent {
  title = 'WF Mailing List';
  todaydate: any;
  componentproperty: any;

  constructor(private httpservice: HttpService, private router: Router) { }

  async onClickSubmit(data: { firstName: string; lastName: string; email: string; }) {
    this.httpservice.sendPostRequest(data).subscribe(results => {
      this.router.navigate(['/confirmation']);
    });

  }
}
