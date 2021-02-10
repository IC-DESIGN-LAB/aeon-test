@charset "UTF-8";
#loader {
  left: 50%;
  top: 50%;
  -webkit-transform: translate(-50%, -50%);
  -moz-transform: translate(-50%, -50%);
  -ms-transform: translate(-50%, -50%);
  -o-transform: translate(-50%, -50%);
  transform: translate(-50%, -50%); }

body {
  font-family: kozuka-gothic-pro, sans-serif;
  font-weight: 500;
  font-style: normal;
  font-size: 14px;
  line-height: 1.5;
  letter-spacing: 0.15em;
  color: #454545; }

/*
    html5doctor.com Reset Stylesheet
    v1.6.1
    Last Updated: 2010-09-17
    Author: Richard Clark - http://richclarkdesign.com
    Twitter: @rich_clark
    */
html,
body,
div,
span,
object,
iframe,
h1,
h2,
h3,
h4,
h5,
h6,
p,
blockquote,
pre,
abbr,
address,
cite,
code,
del,
dfn,
em,
img,
ins,
kbd,
q,
samp,
small,
strong,
sub,
sup,
var,
b,
i,
dl,
dt,
dd,
ol,
ul,
li,
fieldset,
form,
label,
legend,
table,
caption,
tbody,
tfoot,
thead,
tr,
th,
td,
article,
aside,
canvas,
details,
figcaption,
figure,
footer,
header,
hgroup,
menu,
nav,
section,
summary,
time,
mark,
audio,
video {
  margin: 0;
  padding: 0;
  border: 0;
  outline: 0;
  vertical-align: baseline;
  background: transparent; }

body {
  /* プロジェクトによって変動 */
  min-width: auto;
  color: #000;
  line-height: 1.6;
  width: 100%;
  font-variant-numeric: tabular-nums;
  /* safari hover対策 */
  -webkit-font-smoothing: antialiased; }

article,
aside,
details,
figcaption,
figure,
footer,
header,
hgroup,
menu,
nav,
section {
  display: block; }

ul,
ol {
  list-style: none; }

blockquote,
q {
  quotes: none; }

blockquote:before,
blockquote:after,
q:before,
q:after {
  content: "";
  content: none; }

a {
  margin: 0;
  padding: 0;
  vertical-align: baseline;
  text-decoration: none;
  color: inherit; }

/* change colours to suit your needs */
ins {
  background-color: #ff9;
  color: #000;
  text-decoration: none; }

/* change colours to suit your needs */
mark {
  background-color: #ff9;
  color: #000;
  font-style: italic;
  font-weight: bold; }

del {
  text-decoration: line-through; }

abbr[title],
dfn[title] {
  border-bottom: 1px dotted;
  cursor: help; }

table {
  border-collapse: collapse;
  border-spacing: 0; }

/* change border colour to suit your needs */
hr {
  display: block;
  height: 1px;
  border: 0;
  border-top: 1px solid #cccccc;
  margin: 1em 0;
  padding: 0; }

input,
select {
  vertical-align: middle; }

button {
  line-height: 1;
  background-color: transparent;
  border: none;
  cursor: pointer;
  outline: none;
  padding: 0;
  appearance: none; }

img {
  max-width: 100%;
  width: auto; }

@media (max-width: 959px) {
  .isPc {
    display: none !important; } }
@media (min-width: 960px) {
  .isSp {
    display: none !important; } }

.header {
  position: relative; }
  .header-left {
    position: fixed;
    z-index: 1;
    top: 0;
    background-color: #AE1679;
    width: 250px;
    height: 100%;
    padding: 45px 25px 0;
    box-sizing: border-box;
    color: #ffffff;
    overflow: scroll; }
    @media screen and (max-width: 959px) {
      .header-left {
        display: none; } }
  .header-logo {
    margin-bottom: 50px; }
    @media screen and (max-width: 959px) {
      .header-logo {
        margin-bottom: 0; } }
    @media screen and (max-width: 959px) {
      .header-logo img {
        width: 160px; } }
  .header-menuArea-item {
    font-size: 16px;
    font-weight: 600;
    margin-bottom: 20px; }
  .header-menuArea.authc {
    padding-top: 20px;
    border-top: 1px solid #ffffff;
    border-bottom: 1px solid #ffffff;
    margin-bottom: 20px; }
  .header-sns-ttl {
    font-size: 12px;
    font-family: "Helvetica Neue", Helvetica, Arial;
    font-weight: 600;
    margin-bottom: 10px; }
  .header-snsArea {
    display: flex;
    margin-bottom: 40px; }
    .header-snsArea-item {
      width: 33px;
      margin-right: 15px; }
      .header-snsArea-item:last-child {
        margin-right: 0; }
  .header-right {
    position: fixed;
    z-index: 2;
    top: 25px;
    right: 30px; }
    @media screen and (max-width: 959px) {
      .header-right {
        width: 100%;
        background-color: #AE1679;
        right: 0;
        top: 0;
        position: absolute; } }
  .header .sp-nav {
    width: 100%;
    background-color: #AE1679;
    width: 95%;
    margin: auto;
    justify-content: space-between;
    align-items: center;
    padding: 11px 0 8px; }
  .header-authcArea {
    display: flex;
    align-items: center; }
    .header-authcArea-item {
      margin-right: 20px; }
      @media screen and (max-width: 959px) {
        .header-authcArea-item {
          margin-right: 12px; } }
      .header-authcArea-item a {
        display: inline-block;
        font-size: 14px;
        background-color: #fff;
        color: #AE1679;
        font-weight: 600;
        border: 1px solid #AE1679;
        padding: 7px 20px;
        border-radius: 5px;
        text-align: center;
        box-sizing: border-box;
        position: relative; }
        .header-authcArea-item a:after {
          content: '';
          position: absolute;
          width: 0;
          height: 100%;
          top: 0;
          left: 0;
          background-color: #AE1679;
          border-radius: 4px;
          z-index: -1; }
        .header-authcArea-item a:hover {
          color: #fff;
          background: none; }
          .header-authcArea-item a:hover:after {
            content: '';
            position: absolute;
            width: 100%;
            height: 100%;
            top: 0;
            left: 0;
            background-color: #AE1679;
            border-radius: 4px;
            z-index: -1;
            -webkit-transition: all 0.3s;
            -moz-transition: all 0.3s;
            -o-transition: all 0.3s;
            -ms-transition: all 0.3s;
            transition: all 0.3s; }
        @media screen and (max-width: 959px) {
          .header-authcArea-item a {
            color: #ffffff;
            border: none;
            background-color: transparent;
            padding: 0;
            font-size: 10px; } }
      .header-authcArea-item.hd-cart-icon a {
        border: none;
        padding: 7px 10px;
        background: none; }
        .header-authcArea-item.hd-cart-icon a:after {
          content: unset; }
        .header-authcArea-item.hd-cart-icon a img {
          max-width: 35px;
          vertical-align: bottom;
          height: auto;
          width: 100%; }
      .header-authcArea-item:last-child {
        margin-right: 0; }
      @media screen and (max-width: 959px) {
        .header-authcArea-item img {
          display: block;
          margin: 0 auto 5px;
          width: 22px; } }
      .header-authcArea-item img.sp-news-img {
        width: 18px; }
      .header-authcArea-item img.sp-cart-img {
        width: 25px; }
  .header .login-img {
    width: 20px; }

footer {
  width: calc(100% - 250px);
  margin-left: auto; }
  @media screen and (max-width: 959px) {
    footer {
      width: 100%;
      margin: auto; } }
  footer .sns {
    background-color: #EDEDED;
    padding: 40px 0; }
    footer .sns h1 {
      width: 230px;
      margin: 0 auto 20px; }
    footer .sns p {
      font-size: 14px;
      font-family: "Helvetica Neue", Helvetica, Arial;
      font-weight: 600;
      text-align: center;
      color: #6E6E6E;
      margin-bottom: 10px; }
    footer .sns-list {
      max-width: 176px;
      width: 100%;
      margin: 0 auto; }
      footer .sns-list-item {
        display: inline-block;
        margin-right: 15px; }
        footer .sns-list-item img {
          width: 40px; }
  footer .ft-f-navi {
    background-color: rgba(174, 22, 121, 0.8);
    color: #ffffff;
    width: 100%;
    position: fixed;
    bottom: 0;
    z-index: 100; }
    footer .ft-f-navi .nav-list {
      width: 98%;
      margin: auto;
      padding: 7px 0 5px;
      display: -webkit-box;
      display: -moz-box;
      display: -ms-box;
      display: -webkit-flexbox;
      display: -moz-flexbox;
      display: -ms-flexbox;
      display: -webkit-flex;
      display: -moz-flex;
      display: -ms-flex;
      display: flex;
      -webkit-box-lines: multiple;
      -moz-box-lines: multiple;
      -webkit-flex-wrap: wrap;
      -moz-flex-wrap: wrap;
      -ms-flex-wrap: wrap;
      flex-wrap: wrap;
      justify-content: space-between;
      align-items: flex-end; }
      footer .ft-f-navi .nav-list-item {
        font-size: 10px;
        font-weight: 600;
        width: 18.8%;
        text-align: center; }
        @media (max-width: 620px) {
          footer .ft-f-navi .nav-list-item {
            font-size: 10px;
            font-weight: 600;
            width: 17.8%;
            text-align: center;
            letter-spacing: 1px; } }
        footer .ft-f-navi .nav-list-item img {
          display: block;
          margin: 0 auto;
          margin-bottom: 2px; }
      footer .ft-f-navi .nav-list .item01 {
        width: 30px; }
      footer .ft-f-navi .nav-list .item02 {
        width: 50px; }
      footer .ft-f-navi .nav-list .item03 {
        width: 37px; }
      footer .ft-f-navi .nav-list .item04 {
        width: 27px; }
      footer .ft-f-navi .nav-list .item05 {
        width: 37px;
        padding-bottom: 8px; }
  footer .ftNav {
    background-color: #EFEFEF;
    font-size: 12px;
    padding: 15px 30px 13px 0; }
    footer .ftNav-list {
      display: flex;
      max-width: 318px;
      margin-left: auto;
      justify-content: space-between; }
      footer .ftNav-list-item {
        padding: 0 5px;
        position: relative; }
        footer .ftNav-list-item:after {
          content: "";
          width: 0;
          height: 0;
          position: absolute;
          bottom: -1px;
          left: 0;
          background: #fff; }
        footer .ftNav-list-item:hover {
          color: #AE1679;
          -webkit-transition: all 0.3s;
          -moz-transition: all 0.3s;
          -o-transition: all 0.3s;
          -ms-transition: all 0.3s;
          transition: all 0.3s; }
          footer .ftNav-list-item:hover:after {
            width: 100%;
            height: 1px;
            background: #AE1679;
            box-sizing: border-box;
            -webkit-transition: all 0.3s;
            -moz-transition: all 0.3s;
            -o-transition: all 0.3s;
            -ms-transition: all 0.3s;
            transition: all 0.3s; }
        footer .ftNav-list-item:last-child {
          margin-right: 0; }

.copy {
  width: 100%;
  background-color: #464646;
  color: #ffffff;
  text-align: center;
  padding: 10px 0;
  font-size: 10px; }
  @media screen and (max-width: 959px) {
    .copy {
      font-size: 10px; } }

body {
  position: relative; }

.contents {
  display: flex;
  width: 100%; }

.contentsAra {
  width: calc(100% - 250px);
  margin-top: 90px;
  margin-left: auto; }
  @media screen and (max-width: 959px) {
    .contentsAra {
      width: 100%;
      margin-top: 0;
      padding-top: 65px; } }

.wapper {
  max-width: 1280px;
  width: 100%;
  margin: 0 auto; }

img {
  width: 100%;
  vertical-align: bottom;
  height: auto; }

.d-fl {
  display: -webkit-box;
  display: -moz-box;
  display: -ms-box;
  display: -webkit-flexbox;
  display: -moz-flexbox;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: -moz-flex;
  display: -ms-flex;
  display: flex;
  -webkit-box-lines: multiple;
  -moz-box-lines: multiple;
  -webkit-flex-wrap: wrap;
  -moz-flex-wrap: wrap;
  -ms-flex-wrap: wrap;
  flex-wrap: wrap; }

.main {
  background: #fff8f8;
  background: linear-gradient(357deg, #fff8f8 0%, #e6e4e4 100%);
  padding: 30px 0 40px;
  margin-bottom: 60px; }
  @media screen and (max-width: 959px) {
    .main {
      padding: 0 0 15px;
      margin-bottom: 30px; } }
  .main .slider-item {
    width: 560px;
    margin: 20px auto;
    background-color: #ffffff;
    border-radius: 15px;
    padding: 30px;
    box-sizing: border-box;
    box-shadow: 4px 2px 17px -6px rgba(0, 0, 0, 0.6); }
    .main .slider-item a:focus {
      outline: none; }
    @media screen and (max-width: 959px) {
      .main .slider-item {
        padding: 20px;
        border-radius: 8px; } }
    .main .slider-item-thumb {
      text-align: center;
      margin-bottom: 10px; }
      .main .slider-item-thumb img {
        width: 100%; }
    .main .slider-item-detail {
      margin-bottom: 15px; }
      @media screen and (max-width: 959px) {
        .main .slider-item-detail {
          margin-bottom: 8px; } }
    .main .slider-item-name {
      font-size: 17px;
      color: #959595;
      margin-bottom: 5px;
      letter-spacing: 0.05em; }
      @media screen and (max-width: 959px) {
        .main .slider-item-name {
          font-size: 12px; } }
    .main .slider-item-ttl {
      font-size: 22px;
      color: #383838;
      font-weight: 600; }
      @media screen and (max-width: 959px) {
        .main .slider-item-ttl {
          font-size: 17px;
          line-height: 1.5; } }
    .main .slider-item-cate {
      color: #AE1679; }
      .main .slider-item-cate li {
        border: 1px solid #AE1679;
        display: inline-block;
        padding: 5px 20px;
        border-radius: 40px;
        margin-right: 5px; }
        @media screen and (max-width: 959px) {
          .main .slider-item-cate li {
            font-size: 10px;
            padding: 2px 7px;
            letter-spacing: 0.1em;
            margin-right: 3px; } }

.slick-slide {
  transform: scale(0.85);
  transition: 0.5s; }

.slick-active {
  transform: scale(1); }

.slider-container {
  position: absolute;
  width: 600px;
  height: 50px;
  background: #fff;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  z-index: 100; }

div {
  margin: 0;
  padding: 0;
  background: none;
  border: none;
  border-radius: 0;
  outline: none;
  -webkit-appearance: none;
  -moz-appearance: none;
  appearance: none; }

.slide-arrow {
  position: absolute;
  top: 50%;
  margin-top: -15px; }

.prev-arrow {
  width: 530px;
  margin: auto;
  position: absolute;
  left: 50%;
  top: 50%;
  transform: translate(-50%, -50%);
  margin-left: -35px;
  z-index: 1;
  height: 33px;
  background-image: url(../img/prev_arrow.svg);
  background-repeat: no-repeat;
  background-position: center left; }
  @media (max-width: 959px) {
    .prev-arrow {
      height: 35px;
      width: 35px;
      left: 5px;
      top: 50%;
      transform: translate(0, -50%);
      margin-left: 0px; } }

.next-arrow {
  width: 530px;
  margin: auto;
  position: absolute;
  left: 50%;
  top: 50%;
  transform: translate(-50%, -50%);
  margin-left: 35px;
  z-index: 1;
  height: 33px;
  background-image: url(../img/next_arrow.svg);
  background-repeat: no-repeat;
  background-position: center right; }
  @media (max-width: 959px) {
    .next-arrow {
      height: 35px;
      width: 35px;
      right: 5px;
      top: 50%;
      left: unset;
      transform: translate(0, -50%);
      margin-left: 0px; } }

.news-inner {
  display: flex;
  justify-content: space-between;
  align-items: center;
  width: 90%;
  max-width: 1280px;
  margin: 0 auto 60px;
  padding: 30px;
  border-radius: 5px;
  border: 2px solid #AE1679;
  box-sizing: border-box;
  box-shadow: 4px 5px 16px -9px rgba(0, 0, 0, 0.6); }
  @media screen and (max-width: 959px) {
    .news-inner {
      padding: 20px; } }
.news-ttl {
  display: block;
  min-width: 90px;
  margin-right: 50px;
  font-size: 20px;
  font-weight: 600; }
  @media screen and (max-width: 959px) {
    .news-ttl {
      font-size: 16px;
      min-width: auto;
      margin-right: 20px; } }
.news-list {
  display: flex;
  align-items: center; }
  @media screen and (max-width: 959px) {
    .news-list {
      flex-direction: column;
      align-items: baseline; } }
  .news-list-wrap {
    flex: 1;
    flex-direction: column; }
.news-date {
  background: #696969;
  color: #ffffff;
  font-family: "Helvetica Neue", Helvetica, Arial;
  letter-spacing: 0.1em;
  padding: 2px 7px;
  font-weight: 500;
  border-radius: 5px;
  margin-right: 20px; }
  @media screen and (max-width: 959px) {
    .news-date {
      font-size: 12px;
      margin-bottom: 5px; } }
.news-txt {
  font-size: 12px; }
.news-more {
  margin-left: 2em;
  font-size: 16px;
  font-weight: 600;
  color: #AE1679; }

.mainTtl {
  font-size: 32px;
  font-weight: 600;
  color: #383838;
  border-bottom: 2px solid #AE1679;
  margin-bottom: 40px;
  padding-bottom: 5px; }
  @media screen and (max-width: 959px) {
    .mainTtl {
      margin-bottom: 30px;
      font-size: 22px; } }
  @media (max-width: 620px) {
    .mainTtl {
      margin-bottom: 15px; } }

.mylist {
  width: 90%;
  margin-bottom: 80px; }
  @media screen and (max-width: 959px) {
    .mylist {
      margin: 0  0 60px auto;
      width: 95%; } }

.scroll {
  overflow-y: auto;
  -webkit-appearance: none; }
  .scroll-list {
    overflow-x: auto;
    overflow-y: auto;
    white-space: nowrap;
    -webkit-overflow-scrolling: touch; }
  .scroll-item {
    margin-right: 30px;
    display: inline-block;
    width: 240px;
    background: #fff; }
    @media screen and (max-width: 959px) {
      .scroll-item {
        margin-right: 5px;
        width: 130px; } }
    .scroll-item-thum {
      position: relative; }
      .scroll-item-thum img {
        border-radius: 10px;
        vertical-align: bottom; }
        @media screen and (max-width: 959px) {
          .scroll-item-thum img {
            border-radius: 5px; } }
      .scroll-item-thum-more {
        position: absolute;
        z-index: 2;
        bottom: 0;
        right: 0;
        border: 2px solid #AE1679;
        background-color: #ffffff;
        padding: 0 5px 2px;
        border-radius: 5px; }
        @media screen and (max-width: 959px) {
          .scroll-item-thum-more {
            line-height: 1;
            padding: 0 5px 4px; } }
        .scroll-item-thum-more span {
          width: 7px;
          height: 7px;
          background-color: #AE1679;
          display: inline-block;
          border-radius: 10px;
          margin-right: 5px; }
          @media screen and (max-width: 959px) {
            .scroll-item-thum-more span {
              width: 5px;
              height: 5px; } }
          .scroll-item-thum-more span:last-child {
            margin-right: 0; }

.live, .video {
  margin-bottom: 100px;
  width: 90%; }
  @media screen and (max-width: 959px) {
    .live, .video {
      width: 95%;
      margin: 0 0 60px auto; } }

.detail {
  width: 90%;
  margin-bottom: 100px; }
  @media screen and (max-width: 959px) {
    .detail-inner {
      width: 95%; } }
  @media (max-width: 620px) {
    .detail-inner {
      width: 100%;
      overflow: scroll; } }
  .detail-list {
    display: flex;
    flex-wrap: wrap; }
    @media (max-width: 620px) {
      .detail-list {
        flex-wrap: nowrap;
        width: 1660px; } }
  .detail-item {
    width: 31.33%;
    margin-right: 3%;
    margin-bottom: 3%;
    background-color: #ffffff;
    position: relative;
    box-sizing: border-box;
    z-index: 99; }
    @media (max-width: 620px) {
      .detail-item {
        width: 250px;
        margin-right: 35px;
        margin-bottom: 20px;
        margin-top: 20px; } }
    .detail-item:nth-child(3n) {
      margin-right: 0; }
    .detail-item-thumb {
      position: relative; }
      .detail-item-thumb figure img {
        width: 100%;
        vertical-align: bottom;
        border-top-right-radius: 10px; }
        @media (max-width: 620px) {
          .detail-item-thumb figure img {
            border-top-right-radius: 5px; } }
      .detail-item-thumb-date {
        background-color: #AE1679;
        display: inline-block;
        color: #ffffff;
        font-weight: 600;
        font-family: "Helvetica Neue", Helvetica, Arial;
        position: absolute;
        top: 0;
        left: 0;
        letter-spacing: 1px; }
        .detail-item-thumb-date span {
          display: inline-block;
          padding: 4px 10px; }
          @media (max-width: 620px) {
            .detail-item-thumb-date span {
              padding: 2px 5px; } }
        .detail-item-thumb-date date {
          display: inline-block;
          padding: 4px 10px;
          background: #fff;
          color: #AE1679; }
          @media (max-width: 620px) {
            .detail-item-thumb-date date {
              padding: 2px 5px; } }
        @media (max-width: 620px) {
          .detail-item-thumb-date {
            font-size: 10px;
            letter-spacing: 0.1em;
            display: inline-block;
            top: -10px;
            bottom: unset;
            height: auto;
            box-shadow: 0px 0px 6px 1px #ae167940; } }
      .detail-item-thumb-icon {
        justify-content: space-between;
        position: absolute;
        bottom: -16px;
        right: 10px;
        max-width: 70px;
        width: 100%;
        opacity: 0; }
        .detail-item-thumb-icon li {
          width: 48%;
          max-width: 32px; }
    .detail-item-txtArea {
      padding: 15px 0 30px;
      border-bottom-left-radius: 10px;
      border-bottom-right-radius: 10px;
      box-shadow: 4px 5px 16px -9px rgba(0, 0, 0, 0.6);
      box-sizing: border-box;
      background: #fff; }
      @media (max-width: 620px) {
        .detail-item-txtArea {
          border-bottom-left-radius: 5px;
          border-bottom-right-radius: 5px; } }
    .detail-item-txt {
      width: 90%;
      margin: auto; }
      .detail-item-txt-name {
        font-size: 14px;
        color: #AE1679;
        margin-bottom: 10px;
        letter-spacing: 0.1em; }
        @media (max-width: 620px) {
          .detail-item-txt-name {
            font-size: 12px;
            margin-bottom: 0; } }
      .detail-item-txt-ttl {
        font-size: 16px;
        font-weight: 600;
        display: -webkit-box;
        -webkit-box-orient: vertical;
        -webkit-line-clamp: 2;
        text-overflow: ellipsis;
        overflow: hidden;
        line-height: 1.5; }
        @media (max-width: 620px) {
          .detail-item-txt-ttl {
            font-size: 14px;
            -webkit-line-clamp: 3; } }
      .detail-item-txt-text {
        padding-bottom: 10px;
        font-size: 12px;
        opacity: 0;
        display: none;
        margin-top: 10px; }
        @media (max-width: 620px) {
          .detail-item-txt-text {
            opacity: 0;
            display: none; } }
    .detail-item:hover {
      z-index: 100; }
      .detail-item:hover .detail-item-inn {
        border-radius: 15px;
        border-top-left-radius: 0;
        border: 4px solid #AE1679;
        transform: scaleX(1.05) scaleY(1.08);
        -webkit-transition: all .3s ease-in-out;
        transition: all .3s ease-in-out;
        background: #fff;
        position: absolute;
        width: 100%; }
        @media (max-width: 620px) {
          .detail-item:hover .detail-item-inn {
            transform: unset;
            position: unset;
            border: unset; } }
        .detail-item:hover .detail-item-inn .detail-item-thumb-icon {
          opacity: 1;
          -webkit-transition: all .3s ease-in-out;
          transition: all .3s ease-in-out; }
          @media (max-width: 620px) {
            .detail-item:hover .detail-item-inn .detail-item-thumb-icon {
              opacity: 0;
              display: none; } }
        .detail-item:hover .detail-item-inn .detail-item-txt-text {
          padding-bottom: 10px;
          font-size: 12px;
          opacity: 1;
          display: block;
          -webkit-transition: all .3s ease-in-out;
          transition: all .3s ease-in-out; }
          @media (max-width: 620px) {
            .detail-item:hover .detail-item-inn .detail-item-txt-text {
              opacity: 0;
              display: none; } }

.video-txtArea {
  padding-top: 15px; }

.btn {
  position: relative;
  font-size: 18px;
  color: #ffffff;
  font-weight: 600;
  background-color: #AE1679;
  display: block;
  width: 190px;
  text-align: center;
  padding: 10px 0 8px;
  border-radius: 10px;
  margin: 20px auto 0;
  overflow: hidden; }
  @media screen and (max-width: 959px) {
    .btn {
      font-size: 14px;
      border-radius: 5px;
      margin: 25px auto 0; } }
  .btn:focus {
    outline: none; }
    .btn:focus span::after {
      position: absolute;
      top: 50%;
      left: 50%;
      width: 100px;
      height: 100px;
      margin-top: -50px;
      margin-left: -50px;
      content: "";
      background: #EA54B6;
      border-radius: 50%;
      opacity: 0;
      animation: ripple 1s 1 ease-out; }
@keyframes ripple {
  0% {
    opacity: 0.5;
    transform: scale(0); }
  100% {
    opacity: 0;
    transform: scale(4); } }
#loader-bg {
  display: block;
  position: fixed;
  width: 100%;
  height: 100%;
  top: 0px;
  left: 0px;
  background: #AE1679;
  z-index: 9999; }

#loader {
  display: block;
  position: fixed;
  width: 400px;
  text-align: center;
  color: #fff;
  z-index: 2; }
  @media screen and (max-width: 959px) {
    #loader {
      width: 250px; } }

.news-subpage {
  max-width: 1000px;
  width: 90%;
  margin-bottom: 80px; }
  @media screen and (max-width: 959px) {
    .news-subpage {
      margin: 50px auto; } }
  .news-subpage-list {
    padding: 0 20px;
    box-sizing: border-box; }
    @media (max-width: 620px) {
      .news-subpage-list {
        padding: 0; } }
    .news-subpage-list dl {
      display: flex;
      flex-flow: nowrap;
      align-items: center;
      padding-bottom: 20px;
      margin-bottom: 20px;
      border-bottom: 1px solid #C1C1C1; }
      @media (max-width: 620px) {
        .news-subpage-list dl {
          display: block;
          padding-bottom: 10px;
          margin-bottom: 15px; } }
      .news-subpage-list dl dt {
        display: inline-block;
        margin-right: 20px;
        padding: 2px 8px 4px 10px;
        font-family: "Helvetica Neue", Helvetica, Arial;
        background-color: #696969;
        color: #fff;
        font-size: 16px;
        font-weight: bold;
        border-radius: 5px;
        -webkit-border-radius: 5px;
        -moz-border-radius: 5px;
        -ms-border-radius: 5px;
        -o-border-radius: 5px;
        box-sizing: border-box;
        text-align: center;
        letter-spacing: 0.08em; }
        @media (max-width: 620px) {
          .news-subpage-list dl dt {
            margin-right: 0;
            font-size: 14px;
            margin-bottom: 10px;
            padding: 3px 5px 3px 8px;
            letter-spacing: 1px; } }
      .news-subpage-list dl dd {
        position: relative;
        color: #383838;
        font-size: 16px;
        font-weight: 500; }
        @media (max-width: 620px) {
          .news-subpage-list dl dd:after {
            content: '';
            position: absolute;
            top: 35%;
            right: 12px;
            width: 7px;
            height: 7px;
            border-width: 1px 1px 0 0;
            border-style: solid;
            border-color: #383838;
            display: block;
            transform: rotate(45deg); } }
        @media (max-width: 620px) {
          .news-subpage-list dl dd a {
            display: block;
            width: 350px;
            height: 45px;
            overflow: hidden;
            text-overflow: ellipsis;
            font-size: 14px; } }
        @media (max-width: 400px) {
          .news-subpage-list dl dd a {
            width: 270px; } }
  @media (max-width: 620px) {
    .news-subpage-detail {
      padding: 0; } }
  .news-subpage-detail-title {
    color: #191919;
    padding-bottom: 15px;
    border-bottom: 1px solid #AE1679;
    font-size: 20px;
    font-weight: bold;
    font-family: "Helvetica Neue", Helvetica, Arial; }
    @media (max-width: 620px) {
      .news-subpage-detail-title {
        font-size: 18px; } }
    .news-subpage-detail-title span {
      display: block;
      color: #AE1679;
      font-size: 16px;
      font-weight: 600;
      padding-bottom: 5px; }
      @media (max-width: 620px) {
        .news-subpage-detail-title span {
          font-size: 14px; } }
  .news-subpage-detail-content {
    margin: 30px 0 100px; }
    @media (max-width: 620px) {
      .news-subpage-detail-content {
        margin: 20px 0 80px; } }
    .news-subpage-detail-content p {
      color: #191919;
      font-size: 14px;
      letter-spacing: 1px;
      font-weight: 300;
      line-height: 2; }
      @media (max-width: 620px) {
        .news-subpage-detail-content p {
          font-size: 12px; } }
    .news-subpage-detail-content a {
      display: block;
      padding-right: 20px;
      color: #AE1679;
      font-size: 14px;
      font-weight: 300;
      text-decoration: underline; }
  .news-subpage-detail-button {
    display: flex;
    margin-top: 50px;
    justify-content: center;
    align-items: center; }
    .news-subpage-detail-button a {
      color: #464646;
      font-size: 16px;
      font-weight: 600; }
      @media (max-width: 620px) {
        .news-subpage-detail-button a {
          font-size: 14px; } }
    .news-subpage-detail-button-previous {
      position: relative;
      margin-right: 50px; }
      .news-subpage-detail-button-previous:after {
        content: '';
        position: absolute;
        width: 19px;
        height: 19px;
        top: 2px;
        left: -30px;
        background: url(../img/prev_arrow.svg) no-repeat center;
        background-size: 100%; }
    .news-subpage-detail-button-next {
      position: relative; }
      .news-subpage-detail-button-next:after {
        content: '';
        position: absolute;
        width: 19px;
        height: 19px;
        top: 2px;
        right: -30px;
        background: url(../img/next_arrow.svg) no-repeat center;
        background-size: 100%; }

.subpage {
  width: calc(100% - 250px);
  margin-top: 160px;
  margin-left: auto; }
  @media (max-width: 959px) {
    .subpage {
      width: 100%;
      margin-top: 0;
      padding-top: 65px; } }
  .subpage-l-hd {
    position: relative;
    z-index: 1;
    overflow: hidden; }
    .subpage-l-hd:after {
      content: '';
      width: 100%;
      height: 100%;
      position: absolute;
      top: 0;
      left: 0;
      z-index: -1;
      filter: blur(8px);
      -webkit-filter: blur(15px);
      background-image: url(../img/vid-details-hd.png);
      background-size: cover;
      background-position: center center; }
  .subpage-l-bnr {
    max-width: 1280px;
    width: 100%;
    margin: auto; }
    .subpage-l-bnr img {
      width: 100%;
      vertical-align: bottom;
      height: auto; }
  .subpage-l-inn {
    width: 100%;
    margin: 35px auto 150px; }
    @media (max-width: 620px) {
      .subpage-l-inn {
        margin: 25px auto 60px; } }
    .subpage-l-inn .video-details-info p {
      max-width: 1280px;
      width: 90%;
      margin: auto; }
      .subpage-l-inn .video-details-info p span {
        display: inline;
        color: #AE1679;
        font-size: 16px;
        border-bottom: 1px solid #AE1679;
        padding-bottom: 5px;
        font-weight: 700; }
        @media (max-width: 620px) {
          .subpage-l-inn .video-details-info p span {
            font-size: 14px; } }
    .subpage-l-inn .video-details-info h2 {
      max-width: 1280px;
      width: 100%;
      margin: 25px auto 30px;
      font-size: 24px;
      padding: 15px;
      background: #707070;
      color: #fff;
      text-align: center;
      box-sizing: border-box;
      font-weight: bold;
      font-family: Helvetica, sans-serif; }
      @media (max-width: 620px) {
        .subpage-l-inn .video-details-info h2 {
          font-size: 20px;
          margin: 25px auto 15px; } }
    .subpage-l-inn .video-details-ttl {
      max-width: 1280px;
      width: 90%;
      margin: auto; }
      .subpage-l-inn .video-details-ttl h1 {
        font-size: 24px;
        font-weight: 700;
        color: #000;
        font-family: kozuka-gothic-pro, sans-serif; }
        @media (max-width: 620px) {
          .subpage-l-inn .video-details-ttl h1 {
            font-size: 18px; } }
        .subpage-l-inn .video-details-ttl h1 span {
          font-size: 18px;
          font-weight: 500;
          color: #959595;
          font-family: kozuka-gothic-pro, sans-serif;
          padding-bottom: 10px;
          display: inline-block; }
          @media (max-width: 620px) {
            .subpage-l-inn .video-details-ttl h1 span {
              font-size: 14px; } }
      .subpage-l-inn .video-details-ttl ul {
        justify-content: flex-end; }
        .subpage-l-inn .video-details-ttl ul li {
          color: #AE1679;
          font-size: 16px;
          font-weight: 500;
          padding: 15px 0;
          margin-left: 13px;
          font-family: kozuka-gothic-pro, sans-serif; }
          @media (max-width: 620px) {
            .subpage-l-inn .video-details-ttl ul li {
              font-size: 10px;
              padding: 10px 0 5px; } }
    .subpage-l-inn .video-details-content {
      max-width: 1280px;
      width: 90%;
      margin: auto; }
      .subpage-l-inn .video-details-content-01 {
        margin: 30px auto;
        font-size: 16px;
        font-weight: 500;
        font-family: kozuka-gothic-pro, sans-serif; }
        @media (max-width: 620px) {
          .subpage-l-inn .video-details-content-01 {
            font-size: 14px;
            margin: 15px auto 30px; } }
      .subpage-l-inn .video-details-content-02 {
        border: 1px solid #AE1679;
        border-radius: 10px;
        padding: 20px 25px; }
        @media (max-width: 620px) {
          .subpage-l-inn .video-details-content-02 {
            border-radius: 5px;
            padding: 10px 15px; } }
        .subpage-l-inn .video-details-content-02 h2 {
          font-size: 16px;
          font-weight: 700;
          font-family: kozuka-gothic-pro, sans-serif;
          color: #AE1679;
          margin-bottom: 10px; }
          @media (max-width: 620px) {
            .subpage-l-inn .video-details-content-02 h2 {
              font-size: 14px; } }
        .subpage-l-inn .video-details-content-02 ul li {
          margin: 5px 0;
          font-size: 14px;
          font-weight: 500;
          font-family: kozuka-gothic-pro, sans-serif;
          list-style-type: disc;
          margin-left: 12px; }
          @media (max-width: 620px) {
            .subpage-l-inn .video-details-content-02 ul li {
              font-size: 12px; } }
      .subpage-l-inn .video-details-content-03 {
        padding: 30px 0 75px; }
        @media (max-width: 620px) {
          .subpage-l-inn .video-details-content-03 {
            padding: 20px 0 45px; } }
        .subpage-l-inn .video-details-content-03 .video-details-price {
          text-align: center; }
          .subpage-l-inn .video-details-content-03 .video-details-price p {
            font-size: 38px;
            font-family: Helvetica, sans-serif;
            font-weight: bold;
            color: #000; }
            @media (max-width: 620px) {
              .subpage-l-inn .video-details-content-03 .video-details-price p {
                font-size: 24px; } }
            .subpage-l-inn .video-details-content-03 .video-details-price p span {
              font-size: 18px; }
              @media (max-width: 620px) {
                .subpage-l-inn .video-details-content-03 .video-details-price p span {
                  font-size: 12px; } }
        .subpage-l-inn .video-details-content-03 .video-details-add-cart {
          text-align: center; }
          .subpage-l-inn .video-details-content-03 .video-details-add-cart a {
            display: inline-block;
            max-width: 350px;
            width: 100%;
            margin: 10px auto;
            font-size: 22px;
            font-family: kozuka-gothic-pro, sans-serif;
            padding: 19px 0;
            color: #fff;
            background: #AE1679;
            font-weight: bold;
            border-radius: 5px;
            line-height: 1; }
            @media (max-width: 620px) {
              .subpage-l-inn .video-details-content-03 .video-details-add-cart a {
                padding: 15px 0;
                font-size: 16px;
                border-radius: 5px; } }
        .subpage-l-inn .video-details-content-03 .video-details-zoom {
          margin-top: 40px; }
          .subpage-l-inn .video-details-content-03 .video-details-zoom-txt {
            text-align: center;
            font-size: 14px;
            color: #383838;
            font-weight: bold; }
          .subpage-l-inn .video-details-content-03 .video-details-zoom-dnl {
            margin: 10px 0;
            text-align: center; }
            .subpage-l-inn .video-details-content-03 .video-details-zoom-dnl img {
              max-width: 166px;
              width: 100%;
              margin: auto; }
    .subpage-l-inn .video-details-new {
      max-width: 1280px;
      width: 90%;
      margin: auto; }
      .subpage-l-inn .video-details-new-ttl h2 {
        border-bottom: 2px solid #AE1679;
        text-align: left;
        font-size: 24px;
        font-weight: bold;
        font-family: kozuka-gothic-pro, sans-serif; }
        @media (max-width: 620px) {
          .subpage-l-inn .video-details-new-ttl h2 {
            font-size: 18px; } }
      .subpage-l-inn .video-details-new-list {
        margin-top: 40px; }
        .subpage-l-inn .video-details-new-list .detail-item {
          width: 30%;
          margin-right: 4%; }
          @media (max-width: 1150px) {
            .subpage-l-inn .video-details-new-list .detail-item {
              width: 47%;
              margin-right: 4%; } }
          @media (max-width: 620px) {
            .subpage-l-inn .video-details-new-list .detail-item {
              width: 100%;
              margin-right: 0;
              padding-left: 0;
              box-shadow: unset; }
              .subpage-l-inn .video-details-new-list .detail-item:after {
                content: unset; }
              .subpage-l-inn .video-details-new-list .detail-item a {
                display: -webkit-box;
                display: -moz-box;
                display: -ms-box;
                display: -webkit-flexbox;
                display: -moz-flexbox;
                display: -ms-flexbox;
                display: -webkit-flex;
                display: -moz-flex;
                display: -ms-flex;
                display: flex;
                -webkit-box-lines: multiple;
                -moz-box-lines: multiple;
                -webkit-flex-wrap: wrap;
                -moz-flex-wrap: wrap;
                -ms-flex-wrap: wrap;
                flex-wrap: wrap;
                justify-content: space-between;
                align-items: flex-start; } }
          @media screen and (max-width: 959px) {
            .subpage-l-inn .video-details-new-list .detail-item {
              margin-bottom: 6%; } }
          @media screen and (max-width: 959px) {
            .subpage-l-inn .video-details-new-list .detail-item:nth-child(1) {
              padding-left: 0; } }
          .subpage-l-inn .video-details-new-list .detail-item:nth-child(3n) {
            margin-right: 0; }
            @media (max-width: 1150px) {
              .subpage-l-inn .video-details-new-list .detail-item:nth-child(3n) {
                margin-right: 4%; } }
            @media (max-width: 620px) {
              .subpage-l-inn .video-details-new-list .detail-item:nth-child(3n) {
                margin-right: 0; } }
          @media (max-width: 1150px) {
            .subpage-l-inn .video-details-new-list .detail-item:nth-child(2n) {
              margin-right: 0; } }
          @media (max-width: 620px) {
            .subpage-l-inn .video-details-new-list .detail-item .detail-thumb {
              width: 42%;
              border-radius: 10px;
              box-shadow: 10px 10px 0px -4px rgba(174, 22, 121, 0.25); } }
          @media (max-width: 620px) {
            .subpage-l-inn .video-details-new-list .detail-item .detail-thumb-date {
              top: -10px;
              bottom: unset;
              left: 0;
              padding: 1px 8px; } }
          @media (max-width: 620px) {
            .subpage-l-inn .video-details-new-list .detail-item .detail-txtArea {
              width: 58%;
              box-sizing: border-box;
              box-shadow: unset;
              padding: 0 0 0 20px; } }
          .subpage-l-inn .video-details-new-list .detail-item .detail-txtArea .detail-txt-name {
            margin-bottom: 0; }
          @media (max-width: 620px) {
            .subpage-l-inn .video-details-new-list .detail-item .detail-txtArea .detail-txt-ttl {
              font-size: 14px; } }
          @media (max-width: 620px) {
            .subpage-l-inn .video-details-new-list .detail-item .detail-txtArea .detail-tag {
              display: none; } }

.livepage {
  margin-top: 90px; }
  @media screen and (max-width: 959px) {
    .livepage {
      margin-top: 0; } }

.like-btn {
  position: relative;
  max-width: 1280px;
  width: 98%;
  margin: auto; }
  .like-btn-inn {
    position: absolute;
    bottom: 5px;
    right: 0;
    width: 85px;
    margin: auto;
    justify-content: flex-end; }
    @media (max-width: 620px) {
      .like-btn-inn {
        bottom: -10px; } }
    .like-btn-inn img {
      margin-right: 6px;
      width: 20px; }
    .like-btn-inn span {
      color: #AE1679;
      font-weight: 600;
      font-size: 15px;
      line-height: 1.8;
      position: relative; }
      @media (max-width: 620px) {
        .like-btn-inn span {
          font-size: 12px; } }
      .like-btn-inn span:after {
        content: "";
        position: absolute;
        width: 20px;
        height: 20px;
        left: -27px;
        top: 50%;
        transform: translate(0, -55%);
        background-image: url(../img/like-btn-icon.svg);
        background-size: contain;
        background-position: center;
        background-repeat: no-repeat; }
        @media (max-width: 620px) {
          .like-btn-inn span:after {
            width: 15px;
            height: 15px;
            left: -22px; } }
    .like-btn-inn:hover span:after {
      background-image: url(../img/like-btn-icon-hover.svg); }

.liver {
  max-width: 1280px;
  width: 90%;
  margin: 60px auto 145px; }
  @media screen and (max-width: 959px) {
    .liver {
      margin: 60px auto 145px; } }
  @media (max-width: 620px) {
    .liver {
      margin: 60px auto 80px; } }
  .liver-detail {
    width: 90%;
    margin-bottom: 100px; }
    @media screen and (max-width: 959px) {
      .liver-detail-inner {
        width: 100%; } }
    .liver-detail-list {
      display: flex;
      flex-wrap: wrap; }
      @media screen and (max-width: 959px) {
        .liver-detail-list {
          width: 100%; } }
    .liver-detail-item {
      width: 31.33%;
      margin-right: 3%;
      margin-bottom: 3%;
      background-color: #ffffff;
      position: relative;
      box-sizing: border-box;
      z-index: 99; }
      .liver-detail-item:nth-child(3n) {
        margin-right: 0; }
      @media (max-width: 620px) {
        .liver-detail-item {
          width: 100%;
          margin-right: 0;
          margin-bottom: 30px;
          box-shadow: unset; }
          .liver-detail-item:last-child {
            margin-bottom: 0; } }
      @media (max-width: 620px) {
        .liver-detail-item:first-child {
          margin-right: 0; } }
      .liver-detail-item-inn {
        width: 100%;
        border-radius: 10px;
        border-top-left-radius: 0;
        border: 4px solid #fff;
        box-sizing: border-box; }
        @media (max-width: 620px) {
          .liver-detail-item-inn {
            display: -webkit-box;
            display: -moz-box;
            display: -ms-box;
            display: -webkit-flexbox;
            display: -moz-flexbox;
            display: -ms-flexbox;
            display: -webkit-flex;
            display: -moz-flex;
            display: -ms-flex;
            display: flex;
            -webkit-box-lines: multiple;
            -moz-box-lines: multiple;
            -webkit-flex-wrap: wrap;
            -moz-flex-wrap: wrap;
            -ms-flex-wrap: wrap;
            flex-wrap: wrap;
            border: unset; }
            .liver-detail-item-inn .liver-detail-item-inn-link {
              width: 100%;
              height: 100%;
              top: 0;
              left: 0;
              position: absolute;
              z-index: 100; } }
      .liver-detail-item-thumb {
        position: relative; }
        @media (max-width: 620px) {
          .liver-detail-item-thumb {
            width: 42%;
            box-shadow: 10px 10px 0px -4px #ae167940;
            border-radius: 8px;
            -webkit-border-radius: 8px;
            -moz-border-radius: 8px;
            -ms-border-radius: 8px;
            -o-border-radius: 8px; } }
        .liver-detail-item-thumb figure img {
          width: 100%;
          vertical-align: bottom;
          border-top-right-radius: 10px; }
          @media (max-width: 620px) {
            .liver-detail-item-thumb figure img {
              border-top-left-radius: 0;
              border-radius: 5px; } }
        .liver-detail-item-thumb-date {
          background-color: #AE1679;
          display: inline-block;
          color: #ffffff;
          font-weight: 600;
          font-family: "Helvetica Neue", Helvetica, Arial;
          position: absolute;
          top: 0;
          left: 0;
          letter-spacing: 1px; }
          .liver-detail-item-thumb-date span {
            display: inline-block;
            padding: 4px 10px; }
            @media (max-width: 620px) {
              .liver-detail-item-thumb-date span {
                padding: 2px 5px; } }
          .liver-detail-item-thumb-date date {
            display: inline-block;
            padding: 4px 10px;
            background: #fff;
            color: #AE1679; }
            @media (max-width: 620px) {
              .liver-detail-item-thumb-date date {
                padding: 2px 5px; } }
          @media (max-width: 620px) {
            .liver-detail-item-thumb-date {
              font-size: 10px;
              letter-spacing: 0.1em;
              display: inline-block;
              top: -10px;
              bottom: unset;
              height: auto;
              box-shadow: 0px 0px 6px 1px #ae167940; } }
        .liver-detail-item-thumb-icon {
          justify-content: space-between;
          position: absolute;
          bottom: -16px;
          right: 10px;
          max-width: 70px;
          width: 100%;
          opacity: 0; }
          .liver-detail-item-thumb-icon li {
            width: 48%;
            max-width: 32px; }
      .liver-detail-item-txtArea {
        padding: 15px 0 30px;
        border-bottom-left-radius: 10px;
        border-bottom-right-radius: 10px;
        box-shadow: 4px 5px 16px -9px rgba(0, 0, 0, 0.6);
        box-sizing: border-box;
        background: #fff; }
        @media (max-width: 620px) {
          .liver-detail-item-txtArea {
            width: 52%;
            margin-left: 6%;
            position: relative;
            padding: 0;
            box-sizing: border-box;
            box-shadow: unset;
            border-radius: 0px;
            -webkit-border-radius: 0px;
            -moz-border-radius: 0px;
            -ms-border-radius: 0px;
            -o-border-radius: 0px; } }
      .liver-detail-item-txt {
        width: 90%;
        margin: auto; }
        @media (max-width: 620px) {
          .liver-detail-item-txt {
            width: 100%;
            margin-bottom: 0; } }
        .liver-detail-item-txt-name {
          font-size: 14px;
          color: #AE1679;
          margin-bottom: 10px;
          letter-spacing: 0.1em; }
          @media (max-width: 620px) {
            .liver-detail-item-txt-name {
              font-size: 12px;
              margin-bottom: 0; } }
        .liver-detail-item-txt-ttl {
          font-size: 16px;
          font-weight: 600;
          display: -webkit-box;
          -webkit-box-orient: vertical;
          -webkit-line-clamp: 2;
          text-overflow: ellipsis;
          overflow: hidden;
          line-height: 1.5; }
          @media (max-width: 620px) {
            .liver-detail-item-txt-ttl {
              font-size: 14px;
              -webkit-line-clamp: 3; } }
        .liver-detail-item-txt-text {
          padding-bottom: 10px;
          font-size: 12px;
          opacity: 0;
          display: none;
          margin-top: 10px; }
          @media (max-width: 620px) {
            .liver-detail-item-txt-text {
              opacity: 0;
              display: none; } }
      .liver-detail-item-tag {
        text-align: right; }
        @media (max-width: 620px) {
          .liver-detail-item-tag {
            display: none; } }
        .liver-detail-item-tag-item {
          font-size: 10px;
          display: inline-block;
          color: #AE1679;
          margin-right: 5px;
          margin-bottom: 15px; }
          @media (max-width: 620px) {
            .liver-detail-item-tag-item {
              font-size: 8px;
              margin-right: 3px;
              margin-bottom: 0; } }
      .liver-detail-item:hover {
        z-index: 100; }
        .liver-detail-item:hover .liver-detail-item-inn {
          border-radius: 15px;
          border-top-left-radius: 0;
          border: 4px solid #AE1679;
          transform: scaleX(1.05) scaleY(1.08);
          -webkit-transition: all .3s ease-in-out;
          transition: all .3s ease-in-out;
          background: #fff;
          position: absolute;
          width: 100%; }
          @media (max-width: 620px) {
            .liver-detail-item:hover .liver-detail-item-inn {
              transform: unset;
              position: unset;
              border: unset; } }
          .liver-detail-item:hover .liver-detail-item-inn .liver-detail-item-thumb-icon {
            opacity: 1;
            -webkit-transition: all .3s ease-in-out;
            transition: all .3s ease-in-out; }
            @media (max-width: 620px) {
              .liver-detail-item:hover .liver-detail-item-inn .liver-detail-item-thumb-icon {
                opacity: 0;
                display: none; } }
          .liver-detail-item:hover .liver-detail-item-inn .liver-detail-item-txt-text {
            padding-bottom: 10px;
            font-size: 12px;
            opacity: 1;
            display: block;
            -webkit-transition: all .3s ease-in-out;
            transition: all .3s ease-in-out; }
            @media (max-width: 620px) {
              .liver-detail-item:hover .liver-detail-item-inn .liver-detail-item-txt-text {
                opacity: 0;
                display: none; } }

.login-page {
  background: #EDEDED; }

.logout-page {
  width: 100%;
  background: rgba(0, 0, 0, 0.5); }

.login {
  margin-bottom: 290px; }
  @media screen and (max-width: 959px) {
    .login {
      margin-bottom: 80px; } }
  .login .login-form {
    width: 90%;
    max-width: 640px;
    text-align: center;
    margin: 0px auto;
    border: 2px solid #AE1679;
    border-radius: 10px;
    -webkit-border-radius: 10px;
    -moz-border-radius: 10px;
    -ms-border-radius: 10px;
    -o-border-radius: 10px;
    box-shadow: 0px 8px 16px -2px rgba(10, 10, 10, 0.1), 4px 1px 10px -30px rgba(10, 10, 10, 0.02);
    padding: 30px 0px 40px;
    background-color: #fff; }
    @media screen and (max-width: 959px) {
      .login .login-form {
        margin-top: 70px; } }
    @media (max-width: 620px) {
      .login .login-form {
        padding: 25px 0px 40px; } }
    .login .login-form .login-header {
      padding-bottom: 20px;
      border-bottom: 1px solid #E1E1E1; }
      @media (max-width: 620px) {
        .login .login-form .login-header {
          padding-bottom: 20px; } }
      .login .login-form .login-header h2 {
        font-weight: bold;
        font-size: 32px;
        letter-spacing: 0.1em; }
        @media (max-width: 620px) {
          .login .login-form .login-header h2 {
            font-size: 20px; } }
    .login .login-form .login-body {
      padding: 45px 70px 40px; }
      @media screen and (max-width: 959px) {
        .login .login-form .login-body {
          padding: 30px 20px; } }
      .login .login-form .login-body label {
        display: block;
        text-align: left;
        font-weight: 500;
        font-size: 20px;
        letter-spacing: 0.1em;
        margin-bottom: 5px; }
        @media (max-width: 620px) {
          .login .login-form .login-body label {
            font-size: 16px; } }
      .login .login-form .login-body input {
        display: block;
        font-weight: 500;
        font-size: 16px;
        letter-spacing: 0.1em;
        width: 100%;
        max-width: 500px;
        border-radius: 5px;
        -webkit-border-radius: 5px;
        -moz-border-radius: 5px;
        -ms-border-radius: 5px;
        -o-border-radius: 5px;
        -webkit-border-radius: 5px;
        outline: unset;
        border: unset;
        border: 1px solid #C1C1C1;
        background-color: unset;
        padding: 12px 10px;
        box-sizing: border-box;
        margin-bottom: 20px; }
        .login .login-form .login-body input:focus {
          border: 1px solid #AE1679; }
        @media screen and (max-width: 959px) {
          .login .login-form .login-body input {
            border-color: #C1C1C1; } }
      .login .login-form .login-body .login-submit {
        color: #ffffff;
        padding: 15px 60px;
        font-weight: bold;
        font-size: 20px;
        letter-spacing: 0.1em;
        background-color: #AE1679;
        border-radius: 5px;
        -webkit-border-radius: 5px;
        -moz-border-radius: 5px;
        -ms-border-radius: 5px;
        -o-border-radius: 5px;
        margin-top: 10px; }
        @media (max-width: 620px) {
          .login .login-form .login-body .login-submit {
            font-size: 16px; } }
    .login .login-form .login-footer p {
      font-weight: 500;
      font-size: 14px;
      letter-spacing: 0.1em; }
      .login .login-form .login-footer p a {
        color: #AE1679; }
      .login .login-form .login-footer p:last-child {
        margin-top: 10px; }

.logout {
  width: 100%;
  padding-top: 100px; }
  .logout .logout-inner {
    max-width: 635px;
    width: 90%;
    margin: 0 auto;
    padding: 30px 0 54px;
    position: relative;
    border: 4px solid #AE1679;
    background: #fff;
    text-align: center;
    border-radius: 10px;
    -webkit-border-radius: 10px;
    -moz-border-radius: 10px;
    -ms-border-radius: 10px;
    -o-border-radius: 10px; }
    @media screen and (max-width: 959px) {
      .logout .logout-inner {
        padding: 20px 0 54px; } }
    .logout .logout-inner h2 {
      font-size: 36px;
      font-weight: 600;
      padding-bottom: 20px;
      border-bottom: 1px solid #C1C1C1; }
      @media screen and (max-width: 959px) {
        .logout .logout-inner h2 {
          font-size: 24px;
          padding-bottom: 15px; } }
    .logout .logout-inner p {
      font-size: 20px;
      font-weight: 600;
      padding: 35px 0; }
      @media screen and (max-width: 959px) {
        .logout .logout-inner p {
          font-size: 16px;
          padding: 35px 0 0; } }
    .logout .logout-inner .logout-close {
      position: absolute;
      right: 0;
      top: -40px;
      font-size: 25px;
      color: #fff;
      cursor: pointer; }
    .logout .logout-inner .btn {
      max-width: 205px;
      width: 90%;
      font-size: 20px;
      border-radius: 5px;
      -webkit-border-radius: 5px;
      -moz-border-radius: 5px;
      -ms-border-radius: 5px;
      -o-border-radius: 5px;
      font-weight: 500; }
      @media screen and (max-width: 959px) {
        .logout .logout-inner .btn {
          font-size: 16px; } }

.contact .contact-form {
  width: 90%;
  max-width: 640px;
  margin: 0px auto;
  border: 2px solid #AE1679;
  border-radius: 10px;
  -webkit-border-radius: 10px;
  -moz-border-radius: 10px;
  -ms-border-radius: 10px;
  -o-border-radius: 10px;
  padding: 30px 0px 50px;
  background-color: #ffffff;
  box-shadow: 0px 8px 16px -2px rgba(10, 10, 10, 0.1), 4px 1px 10px -30px rgba(10, 10, 10, 0.02); }
  @media screen and (max-width: 959px) {
    .contact .contact-form {
      margin-top: 70px; } }
  .contact .contact-form .contact-header {
    padding-bottom: 20px;
    border-bottom: 1px solid #E1E1E1; }
    .contact .contact-form .contact-header h2 {
      text-align: center;
      font-weight: bold;
      font-size: 32px;
      letter-spacing: 0.1em; }
      @media screen and (max-width: 959px) {
        .contact .contact-form .contact-header h2 {
          font-size: 24px; } }
  .contact .contact-form .contact-body {
    padding: 30px 70px 0px; }
    @media screen and (max-width: 959px) {
      .contact .contact-form .contact-body {
        padding: 30px 20px 0px; } }
    .contact .contact-form .contact-body p {
      text-align: center;
      font-weight: 500;
      font-size: 14px;
      letter-spacing: 0.1em; }
    .contact .contact-form .contact-body label {
      display: block;
      text-align: left;
      font-weight: 500;
      font-size: 20px;
      letter-spacing: 0.1em;
      margin-top: 20px; }
      @media screen and (max-width: 959px) {
        .contact .contact-form .contact-body label {
          font-size: 16px;
          margin-top: 30px; } }
      .contact .contact-form .contact-body label:first-of-type {
        margin-top: 30px; }
    .contact .contact-form .contact-body input, .contact .contact-form .contact-body textarea {
      color: #000000;
      font-weight: 500;
      font-size: 16px;
      letter-spacing: 0.1em;
      border-radius: 5px;
      -webkit-border-radius: 5px;
      -moz-border-radius: 5px;
      -ms-border-radius: 5px;
      -o-border-radius: 5px;
      -webkit-border-radius: 5px;
      outline: unset;
      border: unset;
      border: 1px solid #C1C1C1;
      padding: 12px 10px;
      box-sizing: border-box;
      margin-top: 5px; }
      .contact .contact-form .contact-body input:focus, .contact .contact-form .contact-body textarea:focus {
        border: 1px solid #AE1679; }
    .contact .contact-form .contact-body .contact-name input, .contact .contact-form .contact-body .contact-email input {
      width: 100%; }
      .contact .contact-form .contact-body .contact-name input:last-of-type, .contact .contact-form .contact-body .contact-email input:last-of-type {
        margin-top: 15px; }
    .contact .contact-form .contact-body .contact-message textarea {
      width: 100%;
      resize: none; }
    .contact .contact-form .contact-body .contact-message ~ p {
      text-align: left;
      color: #E80F0F;
      font-weight: 500;
      font-size: 12px;
      letter-spacing: 0.1em; }
    .contact .contact-form .contact-body .submit-btn {
      text-align: center; }
      .contact .contact-form .contact-body .submit-btn .contact-submit {
        display: inline-block;
        color: #ffffff;
        text-align: center;
        font-weight: bold;
        font-size: 20px;
        letter-spacing: 0.1em;
        padding: 15px 60px;
        max-width: 205px;
        width: 100%;
        margin: 50px auto 0;
        border-radius: 5px;
        -webkit-border-radius: 5px;
        -moz-border-radius: 5px;
        -ms-border-radius: 5px;
        -o-border-radius: 5px;
        background-color: #AE1679; }
        @media (max-width: 620px) {
          .contact .contact-form .contact-body .submit-btn .contact-submit {
            font-size: 14px;
            margin: 30px auto 0; } }
  .contact .contact-form .contact-footer {
    text-align: center;
    margin-top: 10px; }
    .contact .contact-form .contact-footer p {
      color: #E80F0F;
      font-weight: 500;
      font-size: 12px;
      letter-spacing: 0.1em; }

.cart * {
  box-sizing: border-box; }
  .cart * h3 {
    font-size: 18px;
    margin-bottom: 10px; }
    @media (max-width: 620px) {
      .cart * h3 {
        margin-bottom: 5px; } }

.cart img {
  width: 100%;
  border-radius: 5px; }

.cart-inner {
  width: 90%;
  max-width: 640px;
  margin: 0 auto;
  padding: 0 50px 130px 0; }
  @media screen and (max-width: 959px) {
    .cart-inner {
      padding: 30px 0 60px 0; } }
  .cart-inner .cart-title {
    font-size: 32px;
    font-weight: 600;
    color: #191919;
    margin-bottom: 20px; }
    @media screen and (max-width: 959px) {
      .cart-inner .cart-title {
        font-size: 20px; } }
    @media (max-width: 620px) {
      .cart-inner .cart-title {
        margin-bottom: 10px; } }
  .cart-inner .cart-total {
    width: 100%;
    padding: 30px 10px;
    margin-bottom: 40px;
    box-shadow: 0px 3px 13px 0px #dddddd;
    background: #fff;
    text-align: center;
    color: #383838;
    border-radius: 5px;
    -webkit-border-radius: 5px;
    -moz-border-radius: 5px;
    -ms-border-radius: 5px;
    -o-border-radius: 5px; }
    .cart-inner .cart-total .cart-amount {
      line-height: 1.7;
      font-size: 38px;
      font-weight: 600;
      font-family: "Helvetica Neue", Helvetica, Arial; }
      @media screen and (max-width: 959px) {
        .cart-inner .cart-total .cart-amount {
          line-height: 1.5; } }
      @media (max-width: 620px) {
        .cart-inner .cart-total .cart-amount {
          font-size: 24px; } }
      .cart-inner .cart-total .cart-amount span {
        font-size: 14px;
        display: block; }
      .cart-inner .cart-total .cart-amount .cart-tax {
        display: inline;
        font-size: 18px;
        vertical-align: middle; }
        @media (max-width: 620px) {
          .cart-inner .cart-total .cart-amount .cart-tax {
            font-size: 12px; } }
    .cart-inner .cart-total .btn {
      width: 300px;
      margin-top: 10px;
      border-radius: 5px;
      -webkit-border-radius: 5px;
      -moz-border-radius: 5px;
      -ms-border-radius: 5px;
      -o-border-radius: 5px; }
      @media screen and (max-width: 959px) {
        .cart-inner .cart-total .btn {
          width: 90%; } }
      @media (max-width: 620px) {
        .cart-inner .cart-total .btn {
          padding: 10px 0;
          font-size: 16px;
          border-radius: 5px; } }
  .cart-inner .cart-list .cart-item {
    border-bottom: 1px solid #C1C1C1;
    padding: 10px 0;
    display: flex;
    justify-content: space-between;
    flex-wrap: wrap; }
    .cart-inner .cart-list .cart-item:first-child {
      border-top: 1px solid #C1C1C1; }
    .cart-inner .cart-list .cart-item .cart-img {
      width: 20.35%; }
      @media screen and (max-width: 959px) {
        .cart-inner .cart-list .cart-item .cart-img {
          width: 32.41%; } }
    .cart-inner .cart-list .cart-item .cart-text {
      width: 77%;
      font-weight: 600;
      display: flex;
      align-items: center;
      flex-wrap: wrap;
      justify-content: space-between; }
      @media screen and (max-width: 959px) {
        .cart-inner .cart-list .cart-item .cart-text {
          display: block;
          width: 63%; } }
    .cart-inner .cart-list .cart-item .cart-item--title {
      width: 75%;
      letter-spacing: 1px;
      font-size: 14px;
      display: -webkit-box;
      -webkit-box-orient: vertical;
      -webkit-line-clamp: 4;
      text-overflow: ellipsis;
      overflow: hidden;
      line-height: 1.5; }
      @media screen and (max-width: 959px) {
        .cart-inner .cart-list .cart-item .cart-item--title {
          width: 100%;
          -webkit-line-clamp: 3; } }
      .cart-inner .cart-list .cart-item .cart-item--title span {
        font-size: 12px;
        color: #959595;
        display: block;
        font-weight: 500; }
    .cart-inner .cart-list .cart-item .cart-item-price {
      width: 95px;
      letter-spacing: 1px;
      font-size: 14px;
      font-family: "Helvetica Neue", Helvetica, Arial; }
      @media screen and (max-width: 959px) {
        .cart-inner .cart-list .cart-item .cart-item-price {
          text-align: right;
          width: 100%; } }
      .cart-inner .cart-list .cart-item .cart-item-price span {
        font-size: 10px;
        text-indent: -12px;
        margin-left: -5px;
        display: inline-block;
        direction: rtl;
        font-family: 'KozGoPr6NRegular'; }
      .cart-inner .cart-list .cart-item .cart-item-price a {
        font-family: 'KozGoPr6NRegular';
        display: flex;
        font-size: 12px;
        width: 40px;
        height: 18px;
        align-items: center;
        justify-content: center;
        margin: 5px 0 0 auto;
        color: #AE1679;
        border: 1px solid #AE1679;
        padding: 5px 0 4px;
        border-radius: 5px;
        -webkit-border-radius: 5px;
        -moz-border-radius: 5px;
        -ms-border-radius: 5px;
        -o-border-radius: 5px; }
        @media screen and (max-width: 959px) {
          .cart-inner .cart-list .cart-item .cart-item-price a {
            display: inline-flex;
            margin: 5px 0 0 20px;
            height: 0;
            font-size: 10px;
            padding: 8px 0; } }
  .cart-inner .cart-totalfee {
    font-size: 16px;
    text-align: right;
    font-weight: 600;
    text-indent: -12px;
    direction: rtl;
    padding: 10px 0; }
    .cart-inner .cart-totalfee span {
      font-family: "Helvetica Neue", Helvetica, Arial;
      font-size: 24px;
      margin-left: 30px;
      text-indent: -10px;
      display: inline-block;
      direction: rtl; }
  .cart-inner .payment {
    font-size: 14px;
    background-color: #AE1679;
    padding: 5px 10px 4px;
    display: flex;
    justify-content: center;
    align-items: center;
    color: #ffffff;
    font-weight: 600;
    width: 120px;
    margin: 0 0 0 auto;
    border-radius: 5px; }

.cart-payment {
  padding: 40px 0 100px;
  text-align: center; }
  @media (max-width: 620px) {
    .cart-payment {
      padding: 40px 0 50px; } }
  .cart-payment h2 {
    font-size: 36px;
    font-weight: 600;
    color: #AE1679;
    margin-bottom: 20px; }
    @media (max-width: 620px) {
      .cart-payment h2 {
        font-size: 24px; } }
  .cart-payment p {
    font-size: 24px;
    font-weight: 600;
    line-height: 1.8;
    margin-bottom: 40px;
    color: #383838; }
    @media (max-width: 620px) {
      .cart-payment p {
        font-size: 20px;
        margin-bottom: 20px; } }
    .cart-payment p span {
      font-size: 16px;
      font-weight: 500;
      display: block; }
      @media (max-width: 620px) {
        .cart-payment p span {
          font-size: 14px; } }
  .cart-payment .cart-payment-button {
    display: flex;
    flex-wrap: wrap;
    max-width: 430px;
    width: 100%;
    margin: 0 auto;
    justify-content: space-between; }
    @media screen and (max-width: 959px) {
      .cart-payment .cart-payment-button {
        display: block; } }
    .cart-payment .cart-payment-button .btn {
      font-size: 20px;
      width: 205px;
      margin: 0;
      border-radius: 5px;
      -webkit-border-radius: 5px;
      -moz-border-radius: 5px;
      -ms-border-radius: 5px;
      -o-border-radius: 5px;
      font-weight: 500; }
      @media screen and (max-width: 959px) {
        .cart-payment .cart-payment-button .btn {
          margin: 0 auto 20px; } }
      @media (max-width: 620px) {
        .cart-payment .cart-payment-button .btn {
          font-size: 16px; } }

.cart-body .header-right {
  width: 100%;
  background-color: #AE1679;
  right: 0;
  top: 0;
  height: 80px; }
  @media screen and (max-width: 959px) {
    .cart-body .header-right {
      height: 65px; } }
.cart-body .header-logo {
  margin-bottom: 0;
  padding: 25px 0 0 20px; }
  @media screen and (max-width: 959px) {
    .cart-body .header-logo {
      padding: 11px 0 0 10px; } }
  .cart-body .header-logo img {
    width: 215px; }
    @media screen and (max-width: 959px) {
      .cart-body .header-logo img {
        width: 160px; } }
.cart-body .contentsAra {
  width: 100%; }

.register-page {
  background: #EDEDED; }

.registration {
  margin-bottom: 190px; }
  @media screen and (max-width: 959px) {
    .registration {
      margin-bottom: 90px; } }
  .registration .regi-form {
    width: 90%;
    max-width: 640px;
    margin: 0px auto;
    border: 2px solid #AE1679;
    border-radius: 10px;
    -webkit-border-radius: 10px;
    -moz-border-radius: 10px;
    -ms-border-radius: 10px;
    -o-border-radius: 10px;
    padding: 30px 0px 30px;
    background-color: #fff;
    box-shadow: 0px 8px 16px -2px rgba(10, 10, 10, 0.1), 4px 1px 10px -30px rgba(10, 10, 10, 0.02); }
    @media screen and (max-width: 959px) {
      .registration .regi-form {
        margin-top: 56px;
        padding: 25px 0px 10px; } }
    .registration .regi-form .regi-header {
      padding-bottom: 25px;
      border-bottom: 1px solid #E1E1E1; }
      @media (max-width: 620px) {
        .registration .regi-form .regi-header {
          padding-bottom: 20px; } }
      .registration .regi-form .regi-header h2 {
        text-align: center;
        font-weight: bold;
        font-size: 32px;
        letter-spacing: 0.1em;
        line-height: 1.5; }
        @media (max-width: 620px) {
          .registration .regi-form .regi-header h2 {
            font-size: 22px; } }
    .registration .regi-form .regi-body {
      padding: 45px 70px 0px; }
      @media screen and (max-width: 959px) {
        .registration .regi-form .regi-body {
          padding: 30px 20px 0; } }
      .registration .regi-form .regi-body label {
        display: block;
        text-align: left;
        font-weight: 500;
        font-size: 20px;
        letter-spacing: 0.1em;
        margin-top: 30px; }
        @media (max-width: 620px) {
          .registration .regi-form .regi-body label {
            font-size: 16px;
            margin-top: 20px; } }
        .registration .regi-form .regi-body label:first-child {
          margin-top: 0px; }
        .registration .regi-form .regi-body label span {
          color: #AE1679;
          font-size: 12px; }
      .registration .regi-form .regi-body input, .registration .regi-form .regi-body select {
        color: #000;
        font-weight: 500;
        font-size: 16px;
        letter-spacing: 0.1em;
        border-radius: 5px;
        -webkit-border-radius: 5px;
        -moz-border-radius: 5px;
        -ms-border-radius: 5px;
        -o-border-radius: 5px;
        -webkit-border-radius: 5px;
        outline: unset;
        border: unset;
        border: 1px solid #C1C1C1;
        padding: 15px 10px;
        box-sizing: border-box;
        margin-top: 10px; }
        @media (max-width: 620px) {
          .registration .regi-form .regi-body input, .registration .regi-form .regi-body select {
            padding: 12px 10px; } }
        .registration .regi-form .regi-body input:focus, .registration .regi-form .regi-body select:focus {
          border: 1px solid #AE1679; }
        .registration .regi-form .regi-body input:placeholder, .registration .regi-form .regi-body select:placeholder {
          border: 1px solid #C1C1C1; }
      .registration .regi-form .regi-body select {
        height: 50px; }
        @media (max-width: 620px) {
          .registration .regi-form .regi-body select {
            height: 44px; } }
      .registration .regi-form .regi-body .regi-name {
        display: flex;
        flex-wrap: wrap;
        justify-content: space-between; }
        .registration .regi-form .regi-body .regi-name input {
          width: calc(50% - 7.5px); }
      .registration .regi-form .regi-body .regi-gender label {
        position: relative;
        display: inline-block;
        margin-top: 10px;
        width: 80px;
        margin-right: 30px;
        text-align: right; }
        @media (max-width: 620px) {
          .registration .regi-form .regi-body .regi-gender label {
            width: 70px; } }
        .registration .regi-form .regi-body .regi-gender label .checkmark {
          position: absolute;
          top: 7px;
          left: 0px;
          height: 20px;
          width: 20px;
          border: 1px solid #C1C1C1;
          border-radius: 50%; }
          @media (max-width: 620px) {
            .registration .regi-form .regi-body .regi-gender label .checkmark {
              top: 0px; } }
          .registration .regi-form .regi-body .regi-gender label .checkmark::after {
            display: none;
            content: "";
            position: absolute;
            top: 2px;
            left: 2px;
            width: 16px;
            height: 16px;
            border-radius: 50%;
            -webkit-border-radius: 50%;
            -moz-border-radius: 50%;
            -ms-border-radius: 50%;
            -o-border-radius: 50%;
            background-color: #AE1679; }
      .registration .regi-form .regi-body .regi-gender input[type='radio'] {
        margin: 0px;
        padding: 0px;
        position: absolute;
        opacity: 0;
        cursor: pointer; }
      .registration .regi-form .regi-body .regi-gender input[type='radio']:checked ~ .checkmark::after {
        display: block; }
      .registration .regi-form .regi-body .regi-birthday {
        display: flex;
        flex-wrap: wrap; }
        .registration .regi-form .regi-body .regi-birthday .select-bd {
          width: calc(33.33% - 13.33px);
          position: relative;
          border: 1px solid #C1C1C1;
          box-sizing: border-box;
          margin-top: 10px;
          border-radius: 5px;
          -webkit-border-radius: 5px;
          -moz-border-radius: 5px;
          -ms-border-radius: 5px;
          -o-border-radius: 5px;
          -webkit-border-radius: 5px;
          z-index: 9; }
          .registration .regi-form .regi-body .regi-birthday .select-bd::after {
            content: "";
            position: absolute;
            top: 50%;
            right: 10px;
            transform: translate(0, -50%);
            width: 8px;
            height: 8px;
            background-image: url(../img/select-af.svg);
            background-size: contain;
            background-repeat: no-repeat; }
          @media screen and (max-width: 959px) {
            .registration .regi-form .regi-body .regi-birthday .select-bd {
              width: calc(50% - 10px); } }
          @media screen and (max-width: 959px) {
            .registration .regi-form .regi-body .regi-birthday .select-bd:first-child {
              width: 100%; } }
          .registration .regi-form .regi-body .regi-birthday .select-bd:nth-child(2) {
            margin-left: 20px;
            margin-right: 20px; }
            @media screen and (max-width: 959px) {
              .registration .regi-form .regi-body .regi-birthday .select-bd:nth-child(2) {
                margin-left: 0px; } }
          .registration .regi-form .regi-body .regi-birthday .select-bd select {
            width: 100%;
            border: none;
            appearance: none;
            -moz-appearance: none;
            -webkit-appearance: none;
            outline: unset;
            background: #fff0;
            position: relative;
            z-index: 1;
            margin: 0; }
      .registration .regi-form .regi-body .regi-postal {
        display: flex;
        flex-wrap: wrap;
        align-items: baseline; }
        .registration .regi-form .regi-body .regi-postal input {
          width: calc(33.33% - 13.33px); }
          @media screen and (max-width: 959px) {
            .registration .regi-form .regi-body .regi-postal input {
              width: calc(50% - 10px); } }
        .registration .regi-form .regi-body .regi-postal span {
          display: block;
          width: 20px;
          color: #707070;
          text-align: center;
          font-weight: 500;
          font-size: 20px; }
        .registration .regi-form .regi-body .regi-postal a {
          position: relative;
          bottom: 0;
          display: block;
          margin-left: 20px;
          text-align: center;
          font-weight: 500;
          font-size: 12px;
          color: #AE1679;
          border: 1px solid #AE1679;
          border-radius: 5px;
          -webkit-border-radius: 5px;
          -moz-border-radius: 5px;
          -ms-border-radius: 5px;
          -o-border-radius: 5px;
          padding: 10px 10px; }
          @media screen and (max-width: 959px) {
            .registration .regi-form .regi-body .regi-postal a {
              width: calc(50% - 10px);
              margin-top: 10px;
              margin-left: 0px;
              padding: 10px 0px; } }
          @media (max-width: 620px) {
            .registration .regi-form .regi-body .regi-postal a {
              padding: 5px 0;
              max-width: 135px;
              width: 100%; } }
          .registration .regi-form .regi-body .regi-postal a span {
            display: inline-block;
            width: 5px;
            height: 5px;
            margin: 0px 8px;
            border-right: 1px solid #AE1679;
            border-bottom: 1px solid #AE1679;
            transform: rotate(-45deg);
            -webkit-transform: rotate(-45deg);
            -moz-transform: rotate(-45deg);
            -ms-transform: rotate(-45deg);
            -o-transform: rotate(-45deg); }
      .registration .regi-form .regi-body .regi-address-gp {
        margin-top: 10px; }
      .registration .regi-form .regi-body .regi-street input {
        width: 100%; }
      .registration .regi-form .regi-body .regi-ph input {
        width: 100%; }
      .registration .regi-form .regi-body .regi-email input {
        width: 100%; }
        .registration .regi-form .regi-body .regi-email input:last-child {
          margin-top: 10px; }
      .registration .regi-form .regi-body .regi-password input {
        width: 100%; }
        .registration .regi-form .regi-body .regi-password input:last-child {
          margin-top: 10px; }
      .registration .regi-form .regi-body .regi-password p {
        color: #E80F0F;
        font-weight: 500;
        font-size: 12px;
        letter-spacing: 0.1em; }
      .registration .regi-form .regi-body .regi-check {
        margin-top: 60px; }
        .registration .regi-form .regi-body .regi-check label {
          margin-left: 25px;
          position: relative;
          display: block;
          font-weight: 500;
          font-size: 14px;
          letter-spacing: 0.1em; }
          @media (max-width: 620px) {
            .registration .regi-form .regi-body .regi-check label {
              font-size: 14px;
              margin-left: 20px; } }
          .registration .regi-form .regi-body .regi-check label a {
            color: #AE1679;
            font-weight: 500;
            font-size: 16px; }
            @media (max-width: 620px) {
              .registration .regi-form .regi-body .regi-check label a {
                font-size: 14px; } }
          .registration .regi-form .regi-body .regi-check label input[type='checkbox'] {
            padding: 0px;
            margin: 0px;
            position: absolute;
            opacity: 0;
            top: 4px;
            left: -24px;
            width: 15px;
            height: 15px;
            cursor: pointer;
            z-index: 1; }
          .registration .regi-form .regi-body .regi-check label .check {
            position: absolute;
            top: 3px;
            left: -25px;
            height: 15px;
            width: 15px;
            border: 1px solid #000000;
            cursor: pointer; }
            .registration .regi-form .regi-body .regi-check label .check::after {
              display: none;
              content: '';
              position: absolute;
              left: 3px;
              top: -3px;
              width: 14px;
              height: 7px;
              border: solid #000000;
              border-width: 0 0 2px 2px;
              transform: rotate(-45deg);
              -webkit-transform: rotate(-45deg);
              -moz-transform: rotate(-45deg);
              -ms-transform: rotate(-45deg);
              -o-transform: rotate(-45deg); }
          .registration .regi-form .regi-body .regi-check label input[type='checkbox']:checked ~ .check::after {
            display: block; }
      .registration .regi-form .regi-body .regi-submit {
        display: block;
        color: #ffffff;
        text-align: center;
        font-weight: bold;
        font-size: 20px;
        letter-spacing: 0.1em;
        padding: 15px 60px;
        margin: 40px auto 0;
        border-radius: 5px;
        -webkit-border-radius: 5px;
        -moz-border-radius: 5px;
        -ms-border-radius: 5px;
        -o-border-radius: 5px;
        background-color: #AE1679; }
        @media (max-width: 620px) {
          .registration .regi-form .regi-body .regi-submit {
            margin: 50px auto 0; } }
    .registration .regi-form .regi-footer {
      text-align: center;
      margin-top: 10px; }
      .registration .regi-form .regi-footer p {
        color: #E80F0F;
        font-weight: 500;
        font-size: 12px;
        letter-spacing: 0.1em; }

@media screen and (max-width: 959px) {
  .registration-edit .regi-form .regi-body {
    padding: 30px 20px 0px; } }
.registration-edit .regi-form .regi-body input, .registration-edit .regi-form .regi-body select {
  color: #000000; }
.registration-edit .regi-form .regi-body .regi-name input {
  width: calc(50% - 10px); }
.registration-edit .regi-form .regi-body .regi-password p {
  margin-top: 10px; }
.registration-edit .regi-form .regi-body-complete {
  width: 82%;
  margin: auto;
  padding: 25px 0; }
  @media (max-width: 620px) {
    .registration-edit .regi-form .regi-body-complete {
      width: 90%;
      margin: auto;
      padding: 20px 0; } }
  .registration-edit .regi-form .regi-body-complete h2 {
    color: #AE1679;
    text-align: center;
    font-weight: 500;
    font-size: 22px;
    letter-spacing: 0.1em;
    line-height: 1.6;
    margin: 30px 0; }
    @media (max-width: 620px) {
      .registration-edit .regi-form .regi-body-complete h2 {
        font-size: 16px;
        margin: 0 0 15px; } }
  .registration-edit .regi-form .regi-body-complete p {
    margin-bottom: 15px;
    text-align: left;
    font-size: 14px; }
  .registration-edit .regi-form .regi-body-complete .submit-btn {
    text-align: center; }
    .registration-edit .regi-form .regi-body-complete .submit-btn .send-mail-submit {
      display: inline-block;
      color: #ffffff;
      text-align: center;
      font-weight: bold;
      font-size: 20px;
      letter-spacing: 0.1em;
      padding: 15px 60px;
      max-width: 205px;
      width: 100%;
      margin: 30px auto 0;
      border-radius: 5px;
      -webkit-border-radius: 5px;
      -moz-border-radius: 5px;
      -ms-border-radius: 5px;
      -o-border-radius: 5px;
      background-color: #AE1679; }
      @media (max-width: 620px) {
        .registration-edit .regi-form .regi-body-complete .submit-btn .send-mail-submit {
          font-size: 16px; } }

::placeholder {
  /* Chrome, Firefox, Opera, Safari 10.1+ */
  color: #C1C1C1;
  opacity: 1;
  /* Firefox */ }

:-ms-input-placeholder {
  /* Internet Explorer 10-11 */
  color: #C1C1C1; }

::-ms-input-placeholder {
  /* Microsoft Edge */
  color: #C1C1C1; }

.reset-compete {
  margin-top: 200px; }
  @media (max-width: 620px) {
    .reset-compete {
      margin-top: 80px; } }
  .reset-compete-hd h2 {
    text-align: center;
    font-size: 24px; }
    @media (max-width: 620px) {
      .reset-compete-hd h2 {
        font-size: 16px; } }
  .reset-compete-top {
    text-align: center; }
    .reset-compete-top a {
      display: inline-block;
      margin-top: 40px;
      font-weight: bold;
      font-size: 20px;
      letter-spacing: 0.1em;
      color: #ffffff;
      background-color: #AE1679;
      border-radius: 5px;
      -webkit-border-radius: 5px;
      -moz-border-radius: 5px;
      -ms-border-radius: 5px;
      -o-border-radius: 5px;
      padding: 10px 60px;
      font-weight: 500; }
      @media (max-width: 620px) {
        .reset-compete-top a {
          font-size: 16px; } }

.thank-you {
  width: 90%;
  max-width: 640px;
  margin: 0px auto;
  border: 2px solid #AE1679;
  border-radius: 5px;
  -webkit-border-radius: 5px;
  -moz-border-radius: 5px;
  -ms-border-radius: 5px;
  -o-border-radius: 5px;
  padding: 45px 0px 50px;
  background-color: #ffffff;
  box-shadow: 0px 8px 16px -2px rgba(10, 10, 10, 0.1), 4px 1px 10px -30px rgba(10, 10, 10, 0.02); }
  @media screen and (max-width: 959px) {
    .thank-you {
      margin-top: 70px;
      margin-bottom: 70px;
      padding: 25px 0px 35px; } }
  .thank-you .thankyou-header {
    padding-bottom: 37px;
    border-bottom: 1px solid #E1E1E1; }
    @media (max-width: 620px) {
      .thank-you .thankyou-header {
        padding-bottom: 20px; } }
    .thank-you .thankyou-header h2 {
      color: #AE1679;
      text-align: center;
      font-weight: bold;
      font-size: 24px;
      letter-spacing: 0.1em;
      line-height: 1; }
      @media (max-width: 620px) {
        .thank-you .thankyou-header h2 {
          font-size: 18px;
          letter-spacing: 0.1em;
          line-height: 1.5; } }
  .thank-you .thankyou-body {
    margin-top: 40px;
    text-align: center; }
    @media (max-width: 620px) {
      .thank-you .thankyou-body {
        margin-top: 30px; } }
    .thank-you .thankyou-body p {
      font-weight: 500;
      font-size: 16px;
      letter-spacing: 0.1em; }
      .thank-you .thankyou-body p:last-of-type {
        margin-top: 30px; }
        @media screen and (max-width: 959px) {
          .thank-you .thankyou-body p:last-of-type {
            margin-top: 20px; } }
      @media screen and (max-width: 959px) {
        .thank-you .thankyou-body p {
          text-align: left;
          padding: 0px 20px; } }
      @media (max-width: 620px) {
        .thank-you .thankyou-body p {
          font-size: 14px; } }
    .thank-you .thankyou-body a {
      display: inline-block;
      margin-top: 30px;
      font-weight: bold;
      font-size: 20px;
      letter-spacing: 0.1em;
      color: #ffffff;
      background-color: #AE1679;
      border-radius: 5px;
      -webkit-border-radius: 5px;
      -moz-border-radius: 5px;
      -ms-border-radius: 5px;
      -o-border-radius: 5px;
      padding: 10px 60px;
      font-weight: 500; }
      @media (max-width: 620px) {
        .thank-you .thankyou-body a {
          font-size: 14px;
          margin-top: 30px; } }

.contact-thank .thankyou-body {
  margin-top: 30px;
  text-align: center; }
  .contact-thank .thankyou-body .contact-thank-you {
    font-size: 18px;
    line-height: 2; }
    @media screen and (max-width: 959px) {
      .contact-thank .thankyou-body .contact-thank-you {
        text-align: center;
        font-size: 16px; } }
    @media (max-width: 620px) {
      .contact-thank .thankyou-body .contact-thank-you {
        text-align: center;
        font-size: 14px;
        padding: 0px 10px; } }

.submylist * {
  box-sizing: border-box; }

.submylist-inner {
  padding-bottom: 70px; }
  @media screen and (max-width: 959px) {
    .submylist-inner {
      padding: 30px 0; } }
  .submylist-inner .submylist-title {
    font-size: 32px;
    text-align: center;
    font-weight: 600;
    margin-bottom: 40px; }
    @media screen and (max-width: 959px) {
      .submylist-inner .submylist-title {
        margin-bottom: 20px;
        font-size: 24px; } }
  .submylist-inner .submylist-tab {
    text-align: center;
    position: relative; }
    .submylist-inner .submylist-tab:after {
      content: "";
      width: 100%;
      height: 2px;
      background: #AE1679;
      position: absolute;
      bottom: 0;
      left: 0;
      z-index: -1; }
    .submylist-inner .submylist-tab li {
      max-width: 250px;
      width: 40%;
      margin: 0 3px;
      display: inline-block;
      background: #AE1679;
      color: #fff;
      border: 2px solid #AE1679;
      border-bottom: none;
      font-size: 20px;
      text-align: center;
      cursor: pointer;
      padding: 10px 0 7px;
      border-radius: 5px 5px 0 0;
      -webkit-border-radius: 5px 5px 0 0;
      -moz-border-radius: 5px 5px 0 0;
      -ms-border-radius: 5px 5px 0 0;
      -o-border-radius: 5px 5px 0 0; }
      @media screen and (max-width: 959px) {
        .submylist-inner .submylist-tab li {
          font-size: 16px; } }
    .submylist-inner .submylist-tab .tab-active {
      background: #fff;
      color: #AE1679; }
  .submylist-inner .submylist-wrap {
    max-width: 1280px;
    width: 90%;
    margin: 45px auto; }
    @media screen and (max-width: 959px) {
      .submylist-inner .submylist-wrap {
        margin: 35px auto; } }
    @media screen and (max-width: 959px) {
      .submylist-inner .submylist-wrap .detail-list {
        flex-wrap: wrap;
        width: 100%; } }
    @media screen and (max-width: 959px) {
      .submylist-inner .submylist-wrap .detail-list .detail-item {
        width: 46%;
        margin-right: 6%;
        margin-bottom: 6%; } }
    @media (max-width: 620px) {
      .submylist-inner .submylist-wrap .detail-list .detail-item {
        width: 100%;
        margin-right: 0;
        margin-bottom: 6%;
        display: -webkit-box;
        display: -moz-box;
        display: -ms-box;
        display: -webkit-flexbox;
        display: -moz-flexbox;
        display: -ms-flexbox;
        display: -webkit-flex;
        display: -moz-flex;
        display: -ms-flex;
        display: flex;
        -webkit-box-lines: multiple;
        -moz-box-lines: multiple;
        -webkit-flex-wrap: wrap;
        -moz-flex-wrap: wrap;
        -ms-flex-wrap: wrap;
        flex-wrap: wrap;
        align-items: flex-start; } }
    .submylist-inner .submylist-wrap .detail-list .detail-item:nth-child(3n) {
      margin-right: 0; }
    @media (max-width: 1150px) {
      .submylist-inner .submylist-wrap .detail-list .detail-item:nth-child(3n) {
        margin-right: 6%; } }
    @media (max-width: 620px) {
      .submylist-inner .submylist-wrap .detail-list .detail-item:nth-child(3n) {
        margin-right: 0%; } }
    @media (max-width: 959px) {
      .submylist-inner .submylist-wrap .detail-list .detail-item:nth-child(2n) {
        margin-right: 0; } }
    @media (max-width: 959px) {
      .submylist-inner .submylist-wrap .detail-list .detail-item:nth-child(1) {
        padding-left: 0; } }
    .submylist-inner .submylist-wrap .detail-list .detail-item:after {
      content: unset; }
    @media (max-width: 620px) {
      .submylist-inner .submylist-wrap .detail-list .detail-item .detail-thumb {
        width: 42%;
        box-shadow: 10px 10px 0px -4px rgba(174, 22, 121, 0.25);
        border-radius: 10px;
        -webkit-border-radius: 10px;
        -moz-border-radius: 10px;
        -ms-border-radius: 10px;
        -o-border-radius: 10px; } }
    .submylist-inner .submylist-wrap .detail-list .detail-item .detail-txtArea {
      padding: 13px 20px 25px; }
      @media (max-width: 620px) {
        .submylist-inner .submylist-wrap .detail-list .detail-item .detail-txtArea {
          position: relative;
          width: 58%;
          padding: 0 0 0 20px;
          box-sizing: border-box;
          box-shadow: unset;
          border-radius: 0px;
          -webkit-border-radius: 0px;
          -moz-border-radius: 0px;
          -ms-border-radius: 0px;
          -o-border-radius: 0px; } }
      .submylist-inner .submylist-wrap .detail-list .detail-item .detail-txtArea .submylist-item-date {
        font-size: 14px;
        color: #AE1679;
        font-family: "Helvetica Neue", Helvetica, Arial;
        padding-bottom: 5px; }
        @media (max-width: 620px) {
          .submylist-inner .submylist-wrap .detail-list .detail-item .detail-txtArea .submylist-item-date {
            font-size: 12px;
            padding-bottom: 4px; } }
      .submylist-inner .submylist-wrap .detail-list .detail-item .detail-txtArea h3 {
        font-size: 16px;
        line-height: 1.4;
        text-decoration: underline;
        text-decoration-color: #AE1679;
        -moz-text-decoration-color: #AE1679;
        display: -webkit-box;
        -webkit-line-clamp: 2;
        -webkit-box-orient: vertical;
        text-overflow: ellipsis;
        overflow: hidden; }
        .submylist-inner .submylist-wrap .detail-list .detail-item .detail-txtArea h3 a {
          text-decoration: #B11679; }
        @media (max-width: 620px) {
          .submylist-inner .submylist-wrap .detail-list .detail-item .detail-txtArea h3 {
            display: -webkit-box;
            -webkit-box-orient: vertical;
            -webkit-line-clamp: 2;
            text-overflow: ellipsis;
            overflow: hidden;
            font-size: 12px; } }
      .submylist-inner .submylist-wrap .detail-list .detail-item .detail-txtArea .btn {
        font-size: 16px;
        width: 100%;
        border-radius: 5px;
        -webkit-border-radius: 5px;
        -moz-border-radius: 5px;
        -ms-border-radius: 5px;
        -o-border-radius: 5px; }
        @media (max-width: 620px) {
          .submylist-inner .submylist-wrap .detail-list .detail-item .detail-txtArea .btn {
            margin-top: 10px;
            padding: 3px 0;
            font-size: 14px; } }

#submylist-live-show {
  display: none; }

.subpage .others-inn {
  max-width: 1000px;
  width: 90%;
  margin: 0 auto 60px; }
  .subpage .others-inn-title {
    padding: 40px 0 20px; }
    .subpage .others-inn-title h2 {
      text-align: center;
      font-weight: bold;
      font-size: 36px;
      letter-spacing: 0.1em;
      line-height: 1.5; }
      @media (max-width: 620px) {
        .subpage .others-inn-title h2 {
          font-size: 20px; } }
  .subpage .others-inn-wrap {
    max-width: 600px;
    width: 100%;
    margin: auto; }
    .subpage .others-inn-wrap nav ul li {
      width: 100%;
      text-align: left;
      padding: 20px 10px;
      border-top: 1px solid #C1C1C1;
      position: relative;
      box-sizing: border-box; }
      @media (max-width: 620px) {
        .subpage .others-inn-wrap nav ul li {
          padding: 10px 5px; } }
      .subpage .others-inn-wrap nav ul li:last-child {
        border-bottom: 1px solid #C1C1C1; }
      .subpage .others-inn-wrap nav ul li:after {
        content: '>';
        position: absolute;
        font-size: 16px;
        color: #000;
        right: 10px;
        top: 50%;
        transform: translate(0, -50%); }
        @media (max-width: 620px) {
          .subpage .others-inn-wrap nav ul li:after {
            font-size: 10px; } }
      .subpage .others-inn-wrap nav ul li a {
        font-size: 24px;
        font-weight: 600;
        display: block;
        width: 100%; }
        @media (max-width: 620px) {
          .subpage .others-inn-wrap nav ul li a {
            font-size: 16px; } }
      .subpage .others-inn-wrap nav ul li:hover:after {
        color: #AE1679; }
      .subpage .others-inn-wrap nav ul li:hover a {
        color: #AE1679; }

.details-list {
  display: flex;
  flex-wrap: wrap; }
  @media (max-width: 620px) {
    .details-list {
      flex-wrap: nowrap;
      width: 1660px; } }
.details-item {
  width: 31.33%;
  margin-right: 3%;
  margin-bottom: 3%;
  background-color: #ffffff;
  position: relative;
  box-sizing: border-box;
  z-index: 99; }
  @media (max-width: 620px) {
    .details-item {
      width: 250px;
      margin-right: 35px;
      margin-bottom: 20px;
      margin-top: 20px; } }
  .details-item:nth-child(3n) {
    margin-right: 0; }
  .details-item-thumb {
    position: relative; }
    .details-item-thumb figure img {
      width: 100%;
      vertical-align: bottom;
      border-top-right-radius: 10px; }
      @media (max-width: 620px) {
        .details-item-thumb figure img {
          border-top-right-radius: 5px; } }
    .details-item-thumb-date {
      background-color: #AE1679;
      display: inline-block;
      color: #ffffff;
      font-weight: 600;
      font-family: "Helvetica Neue", Helvetica, Arial;
      position: absolute;
      top: 0;
      left: 0;
      letter-spacing: 1px; }
      .details-item-thumb-date span {
        display: inline-block;
        padding: 4px 10px; }
        @media (max-width: 620px) {
          .details-item-thumb-date span {
            padding: 2px 5px; } }
      .details-item-thumb-date date {
        display: inline-block;
        padding: 4px 10px;
        background: #fff;
        color: #AE1679; }
        @media (max-width: 620px) {
          .details-item-thumb-date date {
            padding: 2px 5px; } }
      @media (max-width: 620px) {
        .details-item-thumb-date {
          font-size: 10px;
          letter-spacing: 0.1em;
          display: inline-block;
          top: -10px;
          bottom: unset;
          height: auto;
          box-shadow: 0px 0px 6px 1px #ae167940; } }
    .details-item-thumb-icon {
      justify-content: space-between;
      position: absolute;
      bottom: -16px;
      right: 10px;
      max-width: 70px;
      width: 100%;
      opacity: 0; }
      .details-item-thumb-icon li {
        width: 48%;
        max-width: 32px; }
  .details-item-txtArea {
    padding: 15px 0 30px;
    border-bottom-left-radius: 10px;
    border-bottom-right-radius: 10px;
    box-shadow: 4px 5px 16px -9px rgba(0, 0, 0, 0.6);
    box-sizing: border-box;
    background: #fff; }
    @media (max-width: 620px) {
      .details-item-txtArea {
        border-bottom-left-radius: 5px;
        border-bottom-right-radius: 5px; } }
  .details-item-txt {
    width: 90%;
    margin: auto; }
    .details-item-txt-name {
      font-size: 14px;
      color: #AE1679;
      margin-bottom: 10px;
      letter-spacing: 0.1em; }
      @media (max-width: 620px) {
        .details-item-txt-name {
          font-size: 12px;
          margin-bottom: 0; } }
    .details-item-txt-ttl {
      font-size: 16px;
      font-weight: 600;
      display: -webkit-box;
      -webkit-box-orient: vertical;
      -webkit-line-clamp: 2;
      text-overflow: ellipsis;
      overflow: hidden;
      line-height: 1.5; }
      @media (max-width: 620px) {
        .details-item-txt-ttl {
          font-size: 14px;
          -webkit-line-clamp: 3; } }
    .details-item-txt-text {
      padding-bottom: 10px;
      font-size: 12px;
      opacity: 0;
      display: none;
      margin-top: 10px; }
      @media (max-width: 620px) {
        .details-item-txt-text {
          opacity: 0;
          display: none; } }
  .details-item:hover {
    z-index: 100; }
    .details-item:hover .detail-item-inn {
      border-radius: 15px;
      border-top-left-radius: 0;
      border: 4px solid #AE1679;
      transform: scaleX(1.05) scaleY(1.08);
      -webkit-transition: all .3s ease-in-out;
      transition: all .3s ease-in-out;
      background: #fff;
      position: absolute;
      width: 100%; }
      @media (max-width: 620px) {
        .details-item:hover .detail-item-inn {
          transform: unset;
          position: unset;
          border: unset; } }
      .details-item:hover .detail-item-inn .detail-item-thumb-icon {
        opacity: 1;
        -webkit-transition: all .3s ease-in-out;
        transition: all .3s ease-in-out; }
        @media (max-width: 620px) {
          .details-item:hover .detail-item-inn .detail-item-thumb-icon {
            opacity: 0;
            display: none; } }
      .details-item:hover .detail-item-inn .detail-item-txt-text {
        padding-bottom: 10px;
        font-size: 12px;
        opacity: 1;
        display: block;
        -webkit-transition: all .3s ease-in-out;
        transition: all .3s ease-in-out; }
        @media (max-width: 620px) {
          .details-item:hover .detail-item-inn .detail-item-txt-text {
            opacity: 0;
            display: none; } }

.modal-inn .modal-player-thumb {
  width: 100%; }
.modal-inn .modal-player-content {
  width: 90%;
  margin: auto; }
  .modal-inn .modal-player-content-hd h2 {
    font-size: 20px;
    font-weight: 700;
    padding: 2px 0 2px 15px;
    position: relative; }
    .modal-inn .modal-player-content-hd h2 span {
      font-size: 18px;
      margin-right: 10px; }
    .modal-inn .modal-player-content-hd h2:before {
      content: "";
      position: absolute;
      top: 50%;
      left: 0;
      transform: translate(0, -50%);
      height: 80%;
      width: 6px;
      background: #AE1679; }
  .modal-inn .modal-player-content-01 {
    width: 100%;
    margin: 40px 0 30px; }
    .modal-inn .modal-player-content-01-wrap h3 {
      font-size: 24px;
      font-weight: 700;
      color: #000;
      font-family: kozuka-gothic-pro, sans-serif; }
    .modal-inn .modal-player-content-01-wrap ul {
      justify-content: flex-end; }
      .modal-inn .modal-player-content-01-wrap ul li {
        padding: 8px;
        font-size: 10px; }
    .modal-inn .modal-player-content-01-wrap p {
      font-size: 14px;
      text-align: left; }
    .modal-inn .modal-player-content-01-price h3 {
      padding: 17px 0 8px;
      text-align: center;
      font-size: 32px;
      font-weight: bold; }

/*# sourceMappingURL=style.cs.map */
