<!DOCTYPE HTML>
<?cs include:"macros.cs" ?>
<html lang="en">
<?cs include:"head_tag.cs" ?>
<body>
<?cs call:custom_masthead() ?>

  <div id="page">
    <div id="nav-and-content">
      <?cs call:custom_left_nav() ?>

    <div id="page-content">

      <div id="api-info-block">
        <div class="api-level">
          <?cs call:since_tags(package) ?>
          <?cs call:federated_refs(package) ?>
        </div>
      </div>

      <h1 class="page-header">
        <small>package</small><br/>
        <?cs var:package.name ?>
      </h1>

      <div id="naMessage"></div>

      <div id="jd-content" class="api apilevel-<?cs var:package.since.key ?>">

        <?cs if:subcount(package.descr) ?>
          <div class="jd-descr">
            <?cs call:tag_list(package.descr) ?>
          </div>
        <?cs /if ?>

        <?cs def:class_table(label, classes) ?>
          <?cs if:subcount(classes) ?>
            <h2><?cs var:label ?></h2>
            <div class="jd-sumtable">
              <?cs call:class_link_table(classes) ?>
            </div>
          <?cs /if ?>
        <?cs /def ?>

        <hr/>

        <?cs call:class_table("Interfaces", package.interfaces) ?>
        <?cs call:class_table("Classes", package.classes) ?>
        <?cs call:class_table("Annotations", package.annotations) ?>
        <?cs call:class_table("Enums", package.enums) ?>
        <?cs call:class_table("Exceptions", package.exceptions) ?>
        <?cs call:class_table("Errors", package.errors) ?>

      </div>

      </div>
    </div>
  </div>

</body>
</html>
