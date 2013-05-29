<?cs # The default side navigation for the reference docs ?><?cs 
def:custom_left_nav() ?>
<div id="nav-panels">
  <h2>Sofia <small>API Reference</small></h2>
  <ul class="nav nav-list">

    <li <?cs if:(page.title == "Package Index") ?>class="active"<?cs /if ?> >
      <a href="<?cs var:toroot ?>packages.html">Package Index</a>
    </li>
    <li <?cs if:(page.title == "Class Index") ?>class="active"<?cs /if ?> >
      <a href="<?cs var:toroot ?>classes.html">Class Index</a>
    </li>

    <li class="divider"></li>

    <li class="nav-header">Packages</li>
    <?cs each:pkg=docs.packages ?>
      <li class="<?cs if:(package.name == pkg.name) ?>active <?cs /if ?>api apilevel-<?cs var:pkg.since.key ?>">
        <?cs call:package_link(pkg) ?>
        <?cs if:(class.package.name == pkg.name) || (package.name == pkg.name) ?>
          <?cs if:subcount(class.package) ?>
            <ul class="nav nav-list">
              <?cs call:list("Interfaces", class.package.interfaces) ?>
              <?cs call:list("Classes", class.package.classes) ?>
              <?cs call:list("Annotations", class.package.annotations) ?>
              <?cs call:list("Enums", class.package.enums) ?>
              <?cs call:list("Exceptions", class.package.exceptions) ?>
              <?cs call:list("Errors", class.package.errors) ?>
            </ul>
          <?cs elif:subcount(package) ?>
            <ul class="nav nav-list">
              <?cs call:class_link_list("Interfaces", package.interfaces) ?>
              <?cs call:class_link_list("Classes", package.classes) ?>
              <?cs call:class_link_list("Annotations", package.annotations) ?>
              <?cs call:class_link_list("Enums", package.enums) ?>
              <?cs call:class_link_list("Exceptions", package.exceptions) ?>
              <?cs call:class_link_list("Errors", package.errors) ?>
            </ul>
          <?cs /if ?>
        <?cs /if ?>
      </li>
    <?cs /each ?>
  </ul>
</div><!-- end nav-panels --><?cs 
/def ?>