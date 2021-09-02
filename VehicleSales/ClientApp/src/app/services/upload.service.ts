import { Injectable } from '@angular/core';
import { HttpRequest, HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UploadService {

  constructor(private http: HttpClient) { }

  uploadfile = (file) => {
    let formData = new FormData();
    formData.append('file', file);
    const req = new HttpRequest('POST', "fileUpload/upload", formData);
    return this.http.request(req);
  };
}


