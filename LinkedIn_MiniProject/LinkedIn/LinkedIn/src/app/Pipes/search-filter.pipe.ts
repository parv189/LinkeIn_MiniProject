import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'searchFilter'
})
export class SearchFilterPipe implements PipeTransform {

  transform(list:any[],filtertext:string): any {
    return list ? list.filter(item1 => item1.lastName.search(new RegExp(filtertext,'i')) > -1)|| list.filter(item2 => item2.lastName.search(new RegExp(filtertext,'i')) > -1): [];

  }

}
