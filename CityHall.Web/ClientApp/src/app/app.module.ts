import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { FooterComponent } from './footer/footer.component';
import { SmallCardComponent } from './widget/small-card/small-card.component';
import { CardContainerComponent } from './widget/card-container/card-container.component';
import { SmallCardContainerComponent } from './widget/small-card-container/small-card-container.component';
import { CardComponent } from './widget/card/card.component';
import { TagComponent } from './widget/tag/tag.component';
import { CarouselComponent } from './widget/carousel/carousel.component';
import { TagContainerComponent } from './widget/tag-container/tag-container.component';
import { ListPageComponent } from './pages/list-page/list-page.component';
import { NavigationPathComponent } from './pages/navigation-path/navigation-path.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    FooterComponent,
    SmallCardComponent,
    SmallCardContainerComponent,
    CardContainerComponent,
    CardComponent,
    TagComponent,
    CarouselComponent,
    TagContainerComponent,
    ListPageComponent,
    NavigationPathComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'categoria/:name', component: ListPageComponent}

    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
