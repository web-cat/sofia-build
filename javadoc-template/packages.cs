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

      <h1 class="page-header"><?cs var:page.title ?></h1>

      <div class="jd-descr">
        <p><?cs call:tag_list(root.descr) ?></p>
      </div>

      <table class="table table-condensed table-striped table-bordered">
        <tbody>
        <?cs each:pkg = docs.packages ?>
          <tr class="api apilevel-<?cs var:pkg.since.key ?>">
              <td class="jd-linkcol"><?cs call:package_link(pkg) ?></td>
              <td class="jd-descrcol"><?cs call:tag_list(pkg.shortDescr) ?></td>
          </tr>
        <?cs /each ?>
        </tbody>
      </table>

    <?cs include:"footer.cs" ?>

      </div>
    </div>
  </div>

</body>
</html>
