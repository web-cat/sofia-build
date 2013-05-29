<?cs def:custom_masthead() ?>
<!-- div class="navbar navbar-fixed-top">
  <div class="navbar-inner">
    <div class="container-fluid">
      <?cs if:project.name ?>
        <a class="brand" id="masthead-title" href="#"><?cs var:project.name ?></a>
      <?cs /if ?>
      <ul class="nav">
        <li <?cs if:(page.title == "Package Index") ?>class="active"<?cs /if ?> >
          <a href="<?cs var:toroot ?>packages.html">Package Index</a>
        </li>
        <li <?cs if:(page.title == "Class Index") ?>class="active"<?cs /if ?> >
          <a href="<?cs var:toroot ?>classes.html">Class Index</a>
        </li>
      </ul>
      <!--div class="pull-right">
        <?cs call:default_search_box() ?>
        <?cs if:reference && reference.apilevels ?>
          <?cs call:default_api_filter() ?>
        <?cs /if ?>
      </div-->
    </div>
  </div>
</div --><!-- navbar -->
<?cs /def ?>