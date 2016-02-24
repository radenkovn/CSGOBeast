(function () {
    $(document).ready(function () {
        var nameToSearch = $('#search-name').val(),
        minPrice = $('#search-min-price').val(),
        maxPrice = $('#search-min-price').val(),
        groupType = $('#item-group-type').val(),
        qualityType = $('#item-quality-type').val(),
        itemWeaponType = $('#item-weapon-type').val(),
        orderBy = $('#order-by').val(),
        itemClassification = $('#item-classification-type').val(),
        url = '';
        if (nameToSearch) {
            url += '?name=' + nameToSearch;
        }
        else {
            url += '?name='
        }
        if (minPrice) {
            url += '&minprice=' + minPrice;
        }
        if (maxPrice) {
            url += '&maxprice=' + maxPrice;
        }
        if (groupType) {
            url += '&GroupType=' + groupType;
        }
        if (qualityType) {
            url += '&Quality=' + qualityType;
        }
        if (itemWeaponType) {
            url += '&WeaponType=' + itemWeaponType;
        }
        if (orderBy) {
            url += '&Classification=' + itemClassification;
        }
        if (itemClassification) {
            url += '&order=' + orderBy;
        }
        console.log(url);
        $('.query-link').each(function () {
            var $this = $(this);
            var currentHref = $this.attr('href');
            $this.attr('href', currentHref + url);
        });
    })
}());